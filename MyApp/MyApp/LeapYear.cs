public class LeapYear
{
    public int year { get; private set; }
    public LeapYear(int year) => this.year = year;

    public Boolean isLeapYear(){
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
