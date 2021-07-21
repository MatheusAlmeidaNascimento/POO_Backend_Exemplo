namespace POO_Backend_Rec3.Models
{
    public class Musico
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string ShowName(){
            return "Olá "+Nome;
        }
        
        
        
    }
}