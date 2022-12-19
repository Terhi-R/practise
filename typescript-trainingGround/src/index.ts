import { isConstructorDeclaration } from "typescript";

function greet(name: string, birthYear: number) : string {
  const age = new Date().getFullYear() - birthYear;
  return `Hello ${name}, you are ${age} years old`;
}


function isOld(age: number) : boolean {
    if (age > 34) {
        return true;
    }
    return false;
}

function countOdd(arr: number[]) : number {
    //return arr[2];
    return arr.filter(num => num % 2 !== 0).length;
}

function divideThree(str: number) : boolean {
    if (str % 3 === 0) {
        return true;
    }
    return false;
}

function sumEven(arr: number[]) : number {
    let y = 0;
   return arr
   .filter(num => (num % 2 === 0))
    .reduce((n, x) => n + x, y);
  
}

type Address = {
    street: string,
    streetNo: number,
    city: string,
};

type Person = {
    name: string,
    birthYear: number,
    address: Address,
};

class Person2 {
    name: string = '';
    birthYear: number = 0;
   constructor(name: string, birthYear: number) {
       this.name = name;
       this.birthYear = birthYear;
}
}
function getPersonsStreetNo(per : Person) : number {
    return per.address.streetNo;
}

interface IPerson {
    name: string,
    birthYear: number,
};

function getPersonNameString(a : IPerson) : string {
    return `${a.name}, ${a.birthYear.toString()}`;
}

function printThis(p : Person | undefined | null) {
    if(!p) {return 'no person supplied'; };
    return p.name;
}

const optionallyAdd = (num1 : number, num2 : number, num3?:number, num4?:number, num5?:number | undefined | null) : number => {
    let arr = [num1, num2];
    if (num3) {
        arr.push(num3);
    }
    if (num4) {
        arr.push(num4);
    }
    if (num5) {
        arr.push(num5);
    }

    return arr
    .filter(num => num)
    .reduce((a,b) => a+b, 0);
};
/*
function greetPeople(greeting: string, name1?: string, name2?: string, name3?: string, name4?: string, name5?: string, name6?: string, name7?: string) : string {
    let toGreet = `${greeting}`;
    if (name1) {
        toGreet += ` ${name1}`;
    }
    if (name2) {
        toGreet +=  ` and ${name2}`;
    }
    if (name3) {
       toGreet +=  ` and ${name3}`;
    }
    if (name4) {
 toGreet +=  ` and ${name4}`;
    }
    if (name5) {
     toGreet +=  ` and ${name5}`;
    }
    if (name6) {
 toGreet +=  ` and ${name6}`;
    }
    if (name7) {
     toGreet +=  ` and ${name7}`;
    }

    return toGreet;
};
*/

function greetPeople(greeting:string, ...names : string[]) : string {
    return `${greeting}` + ` ${names.join(' and ').trim()}`;
}

function addToStart<T>(list:T[], itemToAdd: T) : T[] {
    return [itemToAdd, ...list];
}

class Wrapper<T> {
    private list: T[];

    constructor(list : T[]) {
        this.list = list;
    }
    
    public getFirst() : T {return this.list[0];}
    public getLast() : T {return this.list[this.list.length -1];}
}

export { addToStart, Wrapper, 
  greet, greetPeople, isOld, countOdd, divideThree, sumEven, Address, Person, getPersonsStreetNo, IPerson, getPersonNameString, printThis, optionallyAdd
};
