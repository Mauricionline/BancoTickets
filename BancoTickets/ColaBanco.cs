using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTickets
{
    class ColaBanco<T>
    {               
        T[] vec;
        int front = 0;
        int rear = 0;
        int tope;


        public ColaBanco(int tope)
        {
            Tope = tope;
            Vec = new T[tope];
        }

        public int Front { get => front; set => front = value; }
        public int Rear { get => rear; set => rear = value; }
        public int Tope { get => tope; set => tope = value; }
        public T[] Vec { get => vec; set => vec = value; }

        public void insertar(T num)
        {
            if (!estaLLena())
            {
                Vec[rear] = num;
                rear++;
            }
        }
        public void eliminar()
        {
            if (!estaVacia())
            {
                front++;
            }
        }
        public bool estaLLena()
        {
            if (rear == tope)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool estaVacia()
        {
            if (front == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
