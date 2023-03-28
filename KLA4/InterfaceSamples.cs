using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA4
{
    // Interface
    internal class InterfaceSamples
    {
        public void Run()
        {
            IMover a;
            a = new TruckMoover();
            a.MoveFromTo("J", "TLV");

            a = new BikeMoover();
            a.MoveFromTo("J", "TLV");

            Move(new TruckMoover(), "J", "TLV");
            Move(new BikeMoover(), "J", "TLV");
        }

        public bool Move(IMover m,string s, string d)
        {
            m.MoveFromTo(s, d);
            return m.HasGarenty();
        }
    }







    interface IMover
    {
        void MoveFromTo(string address, string DestAddress);
        bool HasGarenty();
    }

    class TruckMoover : IMover
    {
        public void MoveFromTo(string address, string DestAddress)
        {
            ///
            System.Threading.Thread.Sleep(1000*3);
        }
        public bool HasGarenty()
        {
            return true;
        }
    }

    class BikeMoover : IMover
    {
        public void MoveFromTo(string address, string DestAddress)
        {
            ///
            System.Threading.Thread.Sleep(1000 * 5);
        }
        public bool HasGarenty()
        {
            return false;
        }
    }












}
