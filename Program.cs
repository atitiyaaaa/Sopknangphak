 class Program {   
    static void Main(string[] args){
        int day,time;
        int num_breakfast =5, num_weekend =2, num_coffee =3;
        int.TryParse(Console.ReadLine(), out day);
        int.TryParse(Console.ReadLine(), out time);

        while(true){
            String menu = Console.ReadLine ();
            if(menu == "End"){
                break;
            }
            if((menu == "Breakfast Set" && num_breakfast == 0)
             ||(menu == "Weekend Set" && num_weekend == 0)
             ||(menu == "Coffee" && num_coffee == 0)){
                Console.WriteLine("Sorry your order is out of stock");
             }
            else if (menu == "Breackfast Set"&& day > 11){
                num_breakfast -=1;
            }
            else if(menu == "Breakfast Set" && time > 11){
                Console.WriteLine("Sorry your order is not available");
            }
            else if(menu == "Weekend Set" && day <= 5){
                Console.WriteLine("Sorry your order is not available");
            }
            else if(menu == "Weekend Set" && day > 5){
                num_coffee -=1;
            }
            else {
                Console.WriteLine("Please enter a valid menu");
            }
        }
    }
}