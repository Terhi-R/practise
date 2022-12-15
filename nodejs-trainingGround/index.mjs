//module.exports.getAge = getAge;
export const getAge = (birthYear, currentYear) => currentYear - birthYear;

const number1 = 1;
const number2 = 2;
const result = number1 + number2;

console.log(`The answer is: ${result}`);

export function getAgeGroup(age) {
  if (age < 0) {
    return "You ain't born yet!";
  } else if (age <= 3) {
    return "toddler";
  } else if (age > 3 || age < 13) {
    return "kid";
  } else if (age > 12 || age < 20) {
    return "teenager";
  } else if (age > 19 || age < 40) {
    return "adult";
  } else if (age === 50) {
    return "prime";
  } else {
    return "you are just old";
  }
}

export const getAgeForPerson = (person, currentYear) => {
  return currentYear - person.birthYear;
};

export function divdelt(num, num2) {
  if (num2 === 0) {
    throw new Error("Do not divide by zero, you!");
  }
  return num / num2;
}

export const addWithLog = (num1, num2, logger) => {
  logger(`About to '${num1} + ${num2}`);
  return num1 + num2;
};
