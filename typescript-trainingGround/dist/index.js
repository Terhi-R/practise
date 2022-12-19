"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.getPersonNameString = exports.getPersonsStreetNo = exports.sumEven = exports.divideThree = exports.countOdd = exports.isOld = exports.greet = void 0;
function greet(name, birthYear) {
    const age = new Date().getFullYear() - birthYear;
    return `Hello ${name}, you are ${age} years old`;
}
exports.greet = greet;
function isOld(age) {
    if (age > 34) {
        return true;
    }
    return false;
}
exports.isOld = isOld;
function countOdd(arr) {
    //return arr[2];
    return arr.filter(num => num % 2 !== 0).length;
}
exports.countOdd = countOdd;
function divideThree(str) {
    if (str % 3 === 0) {
        return true;
    }
    return false;
}
exports.divideThree = divideThree;
function sumEven(arr) {
    let y = 0;
    return arr
        .filter(num => (num % 2 === 0))
        .reduce((n, x) => n + x, y);
}
exports.sumEven = sumEven;
class Person2 {
    constructor(name, birthYear) {
        this.name = '';
        this.birthYear = 0;
        this.name = name;
        this.birthYear = birthYear;
    }
}
function getPersonsStreetNo(per) {
    return per.address.streetNo;
}
exports.getPersonsStreetNo = getPersonsStreetNo;
;
function getPersonNameString(a) {
    return `${a.name}, ${a.birthYear.toString()}`;
}
exports.getPersonNameString = getPersonNameString;
