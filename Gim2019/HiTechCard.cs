using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gim2019
{
    public class HiTechCard
    {

        public string Name { get; set; }
        public int Price { get; set; }

        public string Type { get; set; }

        
        public HiTechCard(string name ,int price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
    }

    public class TypeCounter
    {
        public string Type { get; set; }

        public int Counter { get; set; }
    }
    public class Player
    {
        public int Id { get; set; }

        public HiTechCard[] Cards;


        public Player(int id)
        {
            Id = id;
            Cards = new HiTechCard[30];
        }

        public int GetNumberOfType()
        {
            TypeCounter[] typeCounters = new TypeCounter[30];

            for (int i = 0; i < Cards.Length; i++)
            {
                
                if (Cards[i] != null)
                {
                    string type = Cards[i].Type;

                    AddTypeToCounter(typeCounters, type);
                }
            }

            int numberOfFullType = 0;

            for (int i = 0; i < typeCounters.Length; i++)
            {
                if (typeCounters[i] != null)
                {
                    if (typeCounters[i].Counter == 3)
                    {
                        numberOfFullType += 1;
                    }
                }
            }

            return numberOfFullType;
        }

        private void AddTypeToCounter(TypeCounter[] typeCounters, string type)
        {
            for (int j = 0; j < typeCounters.Length; j++)
            {
                if (typeCounters[j] == null)
                {
                    typeCounters[j] = new TypeCounter();
                    typeCounters[j].Type = type;
                    typeCounters[j].Counter = 1;
                    return;
                }

                if (typeCounters[j].Type == type)
                {
                    typeCounters[j].Counter += 1;
                    return;
                }
            }
        }
    }
}

