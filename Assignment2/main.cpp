#include <iostream>
#include <algorithm>
#include <vector>
#include <string>


using namespace std;

void sortNumbers(vector<float>& numbers)
{
    sort(numbers.begin(), numbers.end());
    cout << "Numbers sorted in ascending: " << endl;
    for (auto num : numbers)
    {
        cout << num << endl;
    }
    cout<<endl;
}


void sortPeopleAge(vector<pair<string, int>>& people)
{
    // uses lambda function that takes two pairs and sorts decending by age
    sort(people.begin(), people.end(), [](pair<string, int> a, pair<string, int> b) {
        // same age, sort by name
        if (a.second == b.second)
        {
            return a.first < b.first;
        }
        // sort by age
        return a.second > b.second;
    });

    // print people by age
    cout << "People sorted by descending age: " << endl;
    for (auto peeps : people)
    {
        cout<< peeps.first << ", " << peeps.second << endl;
    }
    cout<<endl;

}


void sortPeopleNames(vector<pair<string, int>>& people)
{
    // uses lambda function that takes two pairs and sorts by name
    sort(people.begin(), people.end(), [](pair<string, int>& a, pair<string, int>& b){
        return a.first<b.first;
    });

    // print people by name
    cout << "People sorted by name: " << endl;
    for (auto peeps : people)
    {
        cout<<peeps.first<< endl;
    }
    cout<<endl;
}

int main()
{
    vector<pair<string, int>> people = {
        {"Hal", 20},
        {"Susann", 31},
        {"Dwight", 19},
        {"Kassandra", 21},
        {"Lawrence", 25},
        {"Cindy", 22},
        {"Cory", 27},
        {"Mac", 19},
        {"Romana", 27},
        {"Doretha", 32},
        {"Danna", 20},
        {"Zara", 23},
        {"Rosalyn", 26},
        {"Risa", 24},
        {"Benny", 28},
        {"Juan", 33},
        {"Natalie", 25}
    };

    vector<float> numbers = {645.41, 37.59, 76.41, 5.31, -34.23, 1.11, 1.10, 23.46, 635.47, -876.32, 467.83, 62.25};

    sortNumbers(numbers);
    sortPeopleNames(people);
    sortPeopleAge(people);

    return 0;
}
