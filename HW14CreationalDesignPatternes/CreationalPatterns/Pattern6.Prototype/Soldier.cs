using System.Threading;

namespace Pattern6.Prototype
{
    public class Soldier : ISoldierCloneable
    {
        public string Type { get; set; }

        public int Height { get; set; }

        public string Weapon { get; set; }

        public Soldier(string type, int height, string weapon)
        {
            Thread.Sleep(3000); // simulating slow instanciating object
            this.Type = type;
            this.Height = height;
            this.Weapon = weapon;
        }


        public Soldier Clone()
        {
            // Options of cloning in .NET (http://stackoverflow.com/a/966534/1862812)
            // Clone Manually - Tedious, but high level of control
            // Clone with MemberwiseClone - Fastest but only creates a shallow copy, i.e. for reference-type fields the original object and it's clone refer to the same object.
            // Clone with Reflection - Shallow copy by default, can be re-written to do deep copy. Advantage: automated. Disadvantage: reflection is slow.
            // Clone with Serialization - Easy, automated. Give up some control and serialization is slowest of all.


            return this.MemberwiseClone() as Soldier; // this will make shallow copy

            //return new Soldier(this.Type, this.Height, this.Weapon); // this doesn't solve the main problem - the resource waisting
            //return new Soldier(this.Type.Clone() as string, this.Height, this.Weapon); // full deep copy - the resource waisting stays unsolved

        }

        public override string ToString()
        {
            return string.Format("Soldier type: {0}, height: {1}, weapon: {2}", this.Type, this.Height, this.Weapon);
        }
    }
}
