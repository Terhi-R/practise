const prompt = require("prompt-sync")();

const express = require("express");
const app = express();

app.get("/greet/:name", (req, res) => {
  res.send("Welcome to SALT, " + req.params.name);
});

app.listen(3000);
console.log("Open http://localhost:3000/greet/Marcus");

const name = prompt("What is your name? ");
const courseStart = prompt("When does the course start? ");

function yourName(par) {
  return "Welcome to SALT, " + par;
}

function daysLeft(par) {
  let days = 24 * 60 * 60 * 1000;
  let today = new Date();
  let courseDay = par.slice(0, 2);
  let courseMonth = par.slice(3, 5);
  let courseYear = par.slice(6);
  let thisDay = today.getDate();
  let thisMonth = today.getMonth() + 1;
  let thisYear = today.getFullYear();
  let todaysDate = new Date(`${thisMonth}/${thisDay}/${thisYear}`);
  let courseDate = new Date(`${courseMonth}/${courseDay}/${courseYear}`);

  let courseTime = courseDate.getTime();
  let todaysTime = todaysDate.getTime();

  let difference = courseTime - todaysTime;

  let daysLeft = difference / days;

  return `Today it is ${daysLeft} days left until the course starts`;
}

console.log(yourName(name));
console.log(daysLeft(courseStart));
