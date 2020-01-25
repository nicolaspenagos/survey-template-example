using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace model
{
    public class Poll
    {
        private List<Person> peopleList;
        private String listToShow;

        public Poll() {
            peopleList = new List<Person>();
        }

        public String getListToShow() { return listToShow; }

        public List<Person> getPeopleList() {
            return peopleList;
        }

        public List<Person> PeopleList { get; set; }

        public void add(String n, String l, int a, int s, Boolean r) {
           
            peopleList.Add(new Person(n, l, a, s, r));
        }

        public String getInfo() {
            String msg = "";

            int c = 0;
            while (c<peopleList.Count) {
                Person current = peopleList.ElementAt(c);
                msg += current.Name + ";" + current.Lastname + ";" + current.Age + ";" + current.getSemester() + ";" + current.Recycle+";" + "\n";
                c++;
            }
          
            return msg;
        }
        public void print() {

            String msg = getInfo();
            Console.WriteLine("Msg to print: "+msg);

            try
            {
                StreamWriter writeFile = new StreamWriter("C:\\Users\\usuario\\source\\repos\\Template\\Test.txt");
                writeFile.WriteLine(msg);
                writeFile.Flush();
                writeFile.Close();
             
            }
            catch (IOException)
            {
               
            }
        }

        public void load() {

            StreamReader sr = new StreamReader("C:\\Users\\usuario\\source\\repos\\Template\\Test.txt");
            String line="";
            peopleList = null;
            peopleList = new List<Person>();
            listToShow = "";


            while ((line = sr.ReadLine()) != null) {
                String[] parts = line.Split(';');
                if (parts.Length!=1) {
                    String n = parts[0];
                    String l = parts[1];
                    int a = int.Parse(parts[2]);
                    int s = int.Parse(parts[3]);
                
                    bool r = bool.Parse(parts[4]);
                    peopleList.Add(new Person(n, l, a, s, r));

                    for (int i = 0; i < 5; i++)
                    {
                        listToShow += parts[i] + " ";
                    }
                    listToShow += "\n";

                }

            }

            sr.Close();

        }

    }
}
