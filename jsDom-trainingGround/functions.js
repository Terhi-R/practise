myFunctions = {
  getCompanyName: function () {
    return "SALT";
  },

  addListInMain: function (selectedNumber, content) {
    let mainContent = document.querySelector("main");
    let lists = `<li>${content}</li>`;
    if (content == undefined) {
      lists = `<li></li>`;
    }
    let numberOfLists = lists.repeat(selectedNumber);
    let unorderedList = `<ul>${numberOfLists}</ul>`;
    mainContent.innerHTML += unorderedList;
  },
  addListInMainWithAppendChild: function (selectedNumber) {
    let mainContent = document.querySelector("main");
    let lists = document.createElement(`li`);
    let unorderedList = document.createElement(`ul`);
    for (let i = 0; i < selectedNumber.length; i++) {
      lists.textContent(`Item #${i + 1}`);
    }
    unorderedList.appendChild(lists);
    mainContent.appendChild(unorderedList);
  },
};

function removeDiv(id) {
  let selectDivs = document.querySelector("div#" + id);
  if (selectDivs == undefined) {
    return;
  }
  return selectDivs.remove();
}

console.log("Salt> We are writing to the console");
