﻿namespace Problem_03.Wild_farm
{
    public abstract class Food 
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; protected set; } 
    }
}
