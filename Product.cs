namespace Aula26Interfaces
{
    public class Product
    {
        
        public float Price {get;set;}
        public string Name {get;set;}
        public int Code {get;set;}
        
        public Product(){

        }

        public Product(string _name, int _code, float _price){
            
            this.Code = _code;
            this.Name = _name;
            this.Price = _price;
        }

    }
}