namespace BlaisePascal.LessonExempleDomain
{
    
    public class Enemy
    {
        // private 
        private int _health; 

        public int Health 
        {
            get
            {
                return _health;
            }
            set
            {
                if(value < 0)
                {
                   _health = 0 ;
               
                }else if (value > 100)
                
                {
                    _health = 100 ;
               
                }else {
                    _health = value;
                }
            }

        }

        // ho bisogno di un costruttore 
       
        public Enemy() { }
    }
}
