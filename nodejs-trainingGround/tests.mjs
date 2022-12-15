import assert from "assert";
import { isDataView } from "util/types";
import {
  getAge,
  getAgeGroup,
  getAgeForPerson,
  divdelt,
  addWithLog,
} from "./index.mjs";

describe("age calculator", () => {
  //act
  const result = getAge(1972, 2022);
  //assert
  assert.equal(result, 50);
});

it("someone born 2021 is 1 2022", () => {
  //arrange
  //act
  const result = getAge(2021, 2022);
  //assert
  assert.equal(result, 1);
});

describe("age classifier", () => {
  it("0-3 years old should be a toddler", () => {
    //arrange
    //Act
    const result = getAgeGroup(0);

    //assert
    assert.equal(result, "toddler");
  });
  it("4-12 years old should be a kid"),
    () => {
      const result = getAgeGroup(8);
      assert.equal(result, "kid");
    };
  it("13-19 years old should be a teenager");
  it("20-39 years old should be an adult");
  it("above 39 years old... you are just old"),
    () => {
      //arrange
      //Act
      const result = getAgeGroup(40);

      //assert
      assert.equal(result, "you are just old");
    };
  it("But 50 - that is prime age, my friend! PRIME. AGE."),
    () => {
      //arrange
      //Act
      const result = getAgeGroup(50);

      //assert
      assert.equal(result, "prime");
    };
  it("Unborn child"),
    () => {
      const result = getAgeGroup(-4);

      //assert
      assert.equal(result, "You ain't born yet!");
    };
});

/*
describe("constants and variables"),
  () => {
    it("const means constant", () => {
      const aNumber = 1;
      aNumber = 2;
    });
  };*/

it("you can change a let variable"),
  () => {
    let aNumber = 1;
    aNumber = 2;

    assert.equal(aNumber, 2);
  };

it("uninitialized variables are undefined", () => {
  let aNumber;
  assert.equal("undefined", typeof aNumber);
  assert.equal(undefined, aNumber);
});

it("null should be used for not set", () => {
  const peekIntoTheBox = () => {
    return false;
  };
  let isCatAlive = null;

  assert.equal(null, isCatAlive);
  isCatAlive = peekIntoTheBox();
});

it("array keep values", () => {
  const array1 = [1, 2, 3, 4];
  const array2 = ["Marcus", "Eliza", "Obaid"];
  const array3 = ["Marcus", 49, true];
});

it("getting elements out of arrays", () => {
  const names = ["Marcus", "Eliza", "Obaid"];
  const firstElement = names[0];
  const secondElement = names[1];
  const length = names.length;
  const lastElement = names[names.length - 1];
  assert.equal(firstElement, "Marcus");
  assert.equal(secondElement, "Eliza");
  assert.equal(lastElement, "Obaid");
  assert.equal(length, 3);
});

describe("loops does things over and over", () => {
  it("while-loops just keeps going...", () => {
    let counter = 0;
    while (counter < 2) {
      console.log(`Counter is now ${counter}`);
      counter = counter + 1;
    }
  });
});

it("loop through an array with while", () => {
  let index = 0;
  const names = ["Marcus", "Eliza", "Obaid"];

  //act
  while (index < names.length) {
    console.log(`Index is now '${index}'`);
    console.log(`Current element is '${names[index]}'`);

    index += 1;
  }
});

it("loop through an array with for", () => {
  const names = ["Marcus", "Eliza", "Obaid"];

  for (let i = 0; i < names.length; i++) {
    console.log(`i is now '${i}`);
    console.log(`Current element is '${names[i]}'`);
  }
});

it("calling getAge for each age", () => {
  const currentYear = 2022;
  const birthYears = [1972, 2022, 1980];

  for (let i = 0; i < birthYears.length; i++) {
    const age = getAge(birthYears[i], currentYear);

    console.log(
      `If you are born in ${birthYears[i]} you are ${age} in ${currentYear}`
    );
  }
});

it("adding elements to array with push", () => {
  const names = ["Marcus", "Eliza", "Obaid"];
  assert.equal(names.length, 3);

  names.push("Arvid");

  assert.equal(names.length, 4);
  assert.equal(names[3], "Arvid");
});

it("removing elements from array with pop", () => {
  const names = ["Marcus", "Eliza", "Obaid", "Arvid"];
  assert.equal(names.length, 4);

  names.pop();

  assert.equal(names.length, 3);
  assert.equal(names[3], undefined);
});

it("removing elements from array using slice", () => {
  const names = ["Marcus", "Eliza", "Obaid", "Arvid"];
  assert.equal(names.length, 4);
  names.splice(names.length - 1, 1);

  assert.equal(names.length, 3);
  assert.equal(names[3], undefined);

  names.splice(0, 1);
  assert.equal(names[0], "Eliza");

  const newNames = [...names, "Helen"];
  assert.equal(newNames[1], "Obaid");
  assert.equal(newNames[2], "Helen");
});

it("filter an array - mutable", () => {
  const numbers = [10, 23, 1, 33, 8, 12];
  /*
  for (let i = 0; i < numbers.length; i++) {
    if (numbers[i] > 10) {
      numbers.splice(i, 1);
    }
  }
  assert.equal(numbers.length, 3);
*/
  const bigNumbers = numbers.filter((x) => x > 10);
  assert.equal(bigNumbers.length, 3);
  assert.equal(bigNumbers[0], 23);
});

describe("object are for building things", () => {
  it("our first object - a human", () => {
    const person = {
      name: "Marcus",
      birthYear: 1972,
      isTeacher: true,
    };

    assert.equal(person.name, "Marcus");
    assert.equal(person.birthYear, 1972);
    assert.equal(person.isTeacher, true);
  });
});

it("get age for person", () => {
  const currentYear = 2022;
  const person = {
    name: "Marcus",
    birthYear: 1972,
    isTeacher: true,
  };
  const age = getAgeForPerson(person, currentYear);
  assert.equal(age, 50);
});

it("favorite movie series listed", () => {
  const person = {
    name: "Terhi",
    tvseries: ["Friends", "Gilmore Girls", "True Blood"],
  };

  assert.equal(person.tvseries.length, 3);
  assert.equal(person.tvseries[0], "Friends");
  assert.equal(person.tvseries[person.tvseries.length - 1], "True Blood");
});

it("a list of favorite movies with releaseYears", () => {
  const person = {
    name: "Marcus",
    favoriteMovies: [
      {
        title: "Friends",
        releaseYear: 1994,
      },
      {
        title: "Gilmore Girls",
        releaseYear: 2000,
      },
    ],
  };

  assert.equal(person.favoriteMovies.length, 2);
  assert.equal(person.favoriteMovies[0].title, "Friends");
  assert.equal(person.favoriteMovies[0].releaseYear, 1994);
});

it("a longer list", () => {
  const people = [
    {
      name: "Eliza",
      favoriteMovies: [
        { title: "Star Wars IV", releaseYear: 2017 },
        { title: "Star Wars V", releaseYear: 1980 },
      ],
    },
    {
      name: "Terhi",
      favoriteMovies: [
        { title: "Friends", releaseYear: 1994 },
        { title: "Gilmore Girls", releaseYear: 2000 },
      ],
    },
    {
      name: "Obaid",
      favoriteMovies: [
        { title: "Star Wars IV", releaseYear: 2017 },
        { title: "Star Wars V", releaseYear: 1980 },
      ],
    },
  ];

  assert.equal(people[0].name, "Eliza");
  assert.equal(people[1].favoriteMovies[0].title, "Friends");
  assert.equal(people.length, 3);
});

describe("bad things", () => {
  it("dividing things", () => {
    const twoNumbers = divdelt(15, 5);
    assert.equal(twoNumbers, 3);
    try {
      const withZero = divdelt(4, 0);
    } catch (error) {
      assert.equal(error.message, "Do not divide by zero, you!");
    }
  });
});

describe("callbacks", () => {
  it("adding with logger", () => {
    const logThis2 = (message) => {
      console.log(message);
    };
    const result = addWithLog(1, 89, logThis2);
    assert.equal(result, 90);
  });
});

it("adding with inline logger", () => {
  const result = addWithLog(1, 89, (message) => {
    console.log(message);
  });
  assert.equal(result, 90);
});
