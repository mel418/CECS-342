class Person:
  def __init__(self, name, age):
    self.name = name
    self.age = age

  def __str__(self):
     return f"{self.name}; {self.age}"


def main():
  numbers = [645.41, 37.59, 76.41, 5.31, -34.23, 1.11, 1.10, 23.46, 635.47, -876.32, 467.83, 62.25]
  
  people = [
    Person("Hal", 20), Person("Susann", 31), Person("Dwight", 19),
    Person("Kassandra", 21), Person("Lawrence", 25), Person("Cindy", 22),
    Person("Cory", 27), Person("Mac", 19), Person("Romana", 27),
    Person("Doretha", 32), Person("Danna", 20), Person("Zara", 23),
    Person("Rosalyn", 26), Person("Risa", 24), Person("Benny", 28),
    Person("Juan", 33), Person("Natalie", 25)
  ]

  sorted_numbers = sorted(numbers)
  print(f"Sort numbers ascending by numerical value: {sorted_numbers}\n")
  
  print("\nSort people alphabetically (lexicographically) by name: ")
  sorted_people_by_name = sorted(people, key=lambda person: person.name)
  for person in sorted_people_by_name:
    print(person)
  
  print("\nSort people descending by age, where people of the same age should be sorted alphabetically (lexicographically): ")
  sorted_people_by_age = sorted(people, key=lambda person: (-person.age, person.name))
  for person in sorted_people_by_age:
    print(person)

if __name__ == "__main__":
  main()