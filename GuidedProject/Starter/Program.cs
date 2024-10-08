// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string studentGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
       studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // initialize the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize the calculated average of exam + extra credit scores
    decimal  studentAverage = 0;

    // initialize a counter for the number of assignment 
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

     studentAverage = (decimal)(sumAssignmentScores) / examAssignments;

    if ( studentAverage >= 97)
        studentGrade = "A+";

    else if ( studentAverage >= 93)
        studentGrade = "A";

    else if ( studentAverage >= 90)
        studentGrade = "A-";

    else if ( studentAverage >= 87)
        studentGrade = "B+";

    else if ( studentAverage >= 83)
        studentGrade = "B";

    else if ( studentAverage >= 80)
        studentGrade = "B-";

    else if ( studentAverage >= 77)
        studentGrade = "C+";

    else if ( studentAverage >= 73)
        studentGrade = "C";

    else if ( studentAverage >= 70)
        studentGrade = "C-";

    else if ( studentAverage >= 67)
        studentGrade = "D+";

    else if ( studentAverage >= 63)
        studentGrade = "D";

    else if ( studentAverage >= 60)
        studentGrade = "D-";

    else
        studentGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{ studentAverage}\t{studentGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();