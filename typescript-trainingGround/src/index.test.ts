import 'mocha';
import assert from 'assert';

import { Wrapper, addToStart, greetPeople, optionallyAdd, greet, isOld, countOdd, divideThree, sumEven, Address, Person, getPersonsStreetNo, IPerson, getPersonNameString, printThis } from './index';

describe('ts tests', () => {
  it('get greeting', () => {
    // arrange
    const birthYear = 1972;
    const name = 'Marcus';

    // act
    const result = greet(name, birthYear);

    // assert
    assert.strictEqual(result, 'Hello Marcus, you are 50 years old');
  });
});

it('returns true if age is above 35', () => {
  //act
  const is34Old = isOld(34);
  const is35Old = isOld(35);
  const is36Old = isOld(36);

  assert.strictEqual(is34Old, false);
  assert.strictEqual(is35Old, true);
  assert.strictEqual(is36Old, true);
  
});

it('fun with variables', () => {
  //act
  let name : string = 'Marcus';
  let nameImplicit = 'Marcus';
  let nameImplicit2 = name;
  const cool : boolean = true;
  const birthYear = 1972;

  //assert
assert.strictEqual(typeof(cool), 'boolean');
assert.strictEqual(typeof(birthYear), 'number');
assert.strictEqual(typeof(name), 'string');
assert.strictEqual(typeof(nameImplicit), 'string');
assert.strictEqual(typeof(nameImplicit2), 'string');
})

it('arrays are typed in ts', () => {
  const names : string[] = ['Marcus', 'Julia', 'Catherine'];
  const firstFive = [1,2,3,4,5];
} );

it('count odd numbers', () => {
  const firstFive = [1,2,3,4,5];
  const numberOfOdds = countOdd(firstFive);
  assert.strictEqual(numberOfOdds, 3);
})

it('divide by three', () => {
  const number = 15;
  const dividable = divideThree(number);
  assert.strictEqual(dividable, true);
})

it('sum event numbers', () => {
  const nums = [1,2,3,4,5,6,7,8,9,10];
  const sum = sumEven(nums);
  assert.strictEqual(sum, 30);
})

it('gets the street number for a person', () => {
  //arrange
  const p : Person = {
    name: 'Marcus',
    birthYear: 1972,
    address: {
      street: 'Strålgatan',
      streetNo: 23,
      city: 'Stockholm'
    }
  }
  //act
  const streetNo = getPersonsStreetNo(p);
  //assert
  assert.strictEqual(streetNo, 23);
});

it('prints an IPerson', () => {
  //arrange
  const p1 : IPerson = {name: "Marcus", birthYear: 1972};
  const p2 = {name: "David", birthYear: 1975, drummer: true};

  //act
  const p1Address = getPersonNameString(p1);
  const p2Address = getPersonNameString(p2);

  //assert
  assert.strictEqual(p1Address, "Marcus, 1972");
  assert.strictEqual(p2Address, "David, 1975");
});

it('uses union types to allow null', () => {
  //act
  const result1 = printThis(undefined);
  const result2 = printThis(null);

  //assert
  assert.strictEqual(result1, "no person supplied");
  assert.strictEqual(result2, "no person supplied");
});

it('optional parameters', () => {
  const sum = optionallyAdd(1,2,3,4,5);
  assert.strictEqual(sum, 15);
})

it('rest parameters - print names', () => {
  const greeting1 = greetPeople("Hello");
  const greeting2 = greetPeople("Hello", "Marcus");
  const greeting3 = greetPeople("Hello", "Marcus", "Dasha");
  const greeting4 = greetPeople("Hello", "Marcus", "Dasha", "David");
  const greeting5 = greetPeople("Hello","Marcus", "Dasha", "David", "Julia", "Wietse", "Lucas");

  assert.strictEqual(greeting1, "Hello ");
  assert.strictEqual(greeting2, "Hello Marcus");
  assert.strictEqual(greeting3, "Hello Marcus and Dasha");
  assert.strictEqual(greeting4, "Hello Marcus and Dasha and David");
  assert.strictEqual(greeting5, "Hello Marcus and Dasha and David and Julia and Wietse and Lucas");
})

it('add to list', () => {
  //arrange
  const listOfPeople : IPerson[] = [{name: "Marcus", birthYear: 1972}];
  const listOfAddresses : Address[] = [
    {street: "Strålgatan", streetNo: 23, city: "Stockholm"},
    {street: "SchraeschazStrasse", streetNo: 2, city: "Amsterdam"}
  ];

  //act
  const numberOfPeople = addToStart<IPerson>(listOfPeople, {name: "David", birthYear: 1975});
  const numberOfAddresses = addToStart<Address>(listOfAddresses, {street: "Champs Elysee", streetNo: 1, city: "Paris"});

//Assert
assert.strictEqual(numberOfPeople[0].name, 'David');
assert.strictEqual(numberOfAddresses[0].city, 'Paris');
})

it('wrapper for addresses', () => {
  const listOfAddresses : Address[] = [
    {street: "Strålgatan", streetNo: 23, city: "Stockholm"},
    {street: "SchraeschazStrasse", streetNo: 2, city: "Amsterdam"},
    {street: "Chaps Elysee", streetNo: 1, city: "Paris"},
  ];

  const list = new Wrapper<Address>(listOfAddresses);

  assert.strictEqual(list.getFirst().city, 'Stockholm');
  assert.strictEqual(list.getLast().city, 'Paris');
})

it('wrapper for people', () => {
  const listOfPeople : IPerson[] = [
    {name: "Jen", birthYear: 1990},
    {name: "Mona", birthYear: 1985},
    {name: "Cecilia", birthYear: 2000}
  ];

  const list = new Wrapper<IPerson>(listOfPeople);

  assert.strictEqual(list.getFirst().birthYear, 1990);
  assert.strictEqual(list.getLast().name, "Cecilia");
})