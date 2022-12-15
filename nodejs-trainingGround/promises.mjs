import fetch from "node-fetch";

fetch("https://randomuser.me/api/?results=30")
  .then((response) => response.json())
  .then((data) => data.results)
  .then((results) => console.log(`We got ${results.length} rows`));

import { readFile } from "fs";
readFile("thisFileDoesntExist", "utf8", (err, file) => {
  if (err) {
    console.log("We got an error", { err });
  }
  console.log(`That file has ${file.split("\n").length} lines`);
});

fsPromise
  .readFile("promises.mjs", "utf-8")
  .then((file) => console.log(`That file has ${file.split("\n").length} lines`))
  .catch((err) => console.log("We got an error", { err }));
