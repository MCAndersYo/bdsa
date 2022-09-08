public class LeapYear
{

    public void takeInput(){
        Boolean notValidYear = true;
        while (notValidYear){
            Console.WriteLine("Type a year");
             try{
                int year = Convert.ToInt32(Console.ReadLine());
                if (isLeapYear(year)){
                    Console.WriteLine("yay");
                }
                else{
                    Console.WriteLine("nay"); 
                }
                notValidYear = false;
            }
            catch(Exception e){
                Console.WriteLine("Error: Year must be a postive integer");
            }
        }
    } 

    public Boolean isLeapYear(int year){
        if (year < 0){
            throw new Exception();
        }
        if (year < 1582){
            return false;
        }
        if (year % 400 == 0){
            return true;
        }
        else if (year % 4 == 0){
            if (year % 100 == 0){
                return false;
            }
            return true;
        }
        return false;
    }
}
