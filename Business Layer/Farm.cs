using Baitap1.Data_Layer;
using Baitap1.Repository;
using System.Data;


namespace Baitap1.Business_Layer
{
    public class Farm
    {
        private readonly FarmRepository farmRepository;

        public Farm()
        {
            farmRepository = new FarmRepository();
        }

        public void EnterAnimal(IAnimal animal, int amount)
        {
            animal.Amount = amount;
            farmRepository.Save(animal.GetType().Name, amount);
        }

        public string Sound()
        {
            string sound = "";
            DataTable animalList = farmRepository.GetAnimalList();

            foreach (DataRow row in animalList.Rows)
            {
                string animalType = row["AnimalType"].ToString();
                int amount = int.Parse(row["Amount"].ToString());

                for (int i = 0; i < amount; i++)
                {
                    if (animalType == nameof(Cow))
                    {
                        sound += new Cow().Sound() + "\n";
                    }
                    else if (animalType == nameof(Sheep))
                    {
                        sound += new Sheep().Sound() + "\n";
                    }
                    else if (animalType == nameof(Goat))
                    {
                        sound += new Goat().Sound() + "\n";
                    }
                }
            }

            return sound;
        }

        public (int totalAnimal, int totalMilk) Statistic()
        {
            int totalAnimal = 0;
            int totalMilk = 0;

            DataTable animalList = farmRepository.GetAnimalList();

            foreach (DataRow row in animalList.Rows)
            {
                string animalType = row["AnimalType"].ToString();
                int amount = int.Parse(row["Amount"].ToString());

                int sua = 0;
                int con = 0;

                for (int i = 0; i < amount; i++)
                {
                    if (animalType == nameof(Cow))
                    {
                        sua += new Cow().Milk();
                        con += new Cow().GiveBirth();
                    }
                    else if (animalType == nameof(Sheep))
                    {
                        sua += new Sheep().Milk();
                        con += new Sheep().GiveBirth();
                    }
                    else if (animalType == nameof(Goat))
                    {
                        sua += new Goat().Milk();
                        con += new Goat().GiveBirth();
                    }
                }

                // Cập nhật số lượng sau khi sinh con
                farmRepository.Update(animalType, amount + con);

                totalMilk += sua;
                totalAnimal += amount + con;
            }

            return (totalAnimal, totalMilk);
        }
    }

}
