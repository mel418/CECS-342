#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Person struct
typedef struct {
    char name[20];
    int age;
} Person;

// Comparison function for numbers (ascending)
int compare_numbers(const void* a, const void* b) {
    float num1 = *(float*)a;
    float num2 = *(float*)b;
    return (num1 > num2) - (num1 < num2);
}

// Comparison function for people by name (lexicographical)
int compare_names(const void* a, const void* b) {
    Person* person1 = (Person*)a;
    Person* person2 = (Person*)b;
    return strcmp(person1->name, person2->name);
}

// Comparison function for people by age (descending), then by name
int compare_ages(const void* a, const void* b) {
    Person* person1 = (Person*)a;
    Person* person2 = (Person*)b;
    if (person1->age != person2->age) {
        return person2->age - person1->age;
    }
    return strcmp(person1->name, person2->name);
}

int main() {
    // Floating point numbers
    float numbers[] = {645.41, 37.59, 76.41, 5.31, -34.23, 1.11, 1.10, 23.46, 635.47, -876.32, 467.83, 62.25};
    int num_count = sizeof(numbers) / sizeof(numbers[0]);

    // People
    Person people[] = {
        {"Hal", 20}, {"Susann", 31}, {"Dwight", 19}, {"Kassandra", 21}, {"Lawrence", 25},
        {"Cindy", 22}, {"Cory", 27}, {"Mac", 19}, {"Romana", 27}, {"Doretha", 32},
        {"Danna", 20}, {"Zara", 23}, {"Rosalyn", 26}, {"Risa", 24}, {"Benny", 28},
        {"Juan", 33}, {"Natalie", 25}
    };
    int people_count = sizeof(people) / sizeof(people[0]);

    // Sort numbers
    qsort(numbers, num_count, sizeof(float), compare_numbers);
    // Print sorted numbers
    printf("Sorted numbers:\n");
    for (int i = 0; i < num_count; i++) {
        printf("%.2f ", numbers[i]);
    }
    printf("\n\n");
  
    // Sort people by name
    qsort(people, people_count, sizeof(Person), compare_names);

    // Print people sorted by name
    printf("Sorted people by name:\n");
    for (int i = 0; i < people_count; i++) {
        printf("%s, %d\n", people[i].name, people[i].age);
    }
    printf("\n");
    
    // Sort people by age descending, then by name
    qsort(people, people_count, sizeof(Person), compare_ages);

    // Print people sorted by age
    printf("Sorted people by age:\n");
    for (int i = 0; i < people_count; i++) {
        printf("%s, %d\n", people[i].name, people[i].age);
    }

    return 0;
}
