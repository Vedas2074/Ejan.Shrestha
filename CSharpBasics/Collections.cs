using System.Collections.Generic;

public class Collections
{
public void LearnAboutList()
{
List<string> names = new List<string>();
List<string> names1 = new List<string> {"Ram", "Hari"};
names.Add("Ejan");
names.Add("Ejan1");
names.Add("Ejan2");
names.Add("Ejan3");

names.Sort();

}

public void LearnAboutDictionary()
{
//Hold key-value pairs
Dictionary<string, string> countryCapital = new Dictionary<string, string>
{
["Bhutan"] = "Thimpu",
["China"] = "Beijing"
};

countryCapital.Add("Nepal", "Kathmandu");
countryCapital.Add("India", "Delhi");
countryCapital.Add("USA", "New York");
countryCapital.Add("Russia", "Moscow");


}
}