let addRows = () => {
  let table = document.querySelector("table tbody");
  fetch("https://localhost:5000/api/Addresses")
    .then((response) => response.json())
    .then((data) => {
      data.forEach(function (e, i) {
        let tr = document.createElement("tr");
        if (data[i].id % 2 !== 0) {
          tr.innerHTML += `
                  <td id="id" class="crows">${data[i].id}</td>
                  <td class="crows">${data[i].street}</td>
                  <td class="crows">${data[i].streetNr}</td>
                  <td class="crows">${data[i].postCode}</td>
                  <td class="crows">${data[i].city}</td>
                  <td class="crows" id="delete"></td>`;
        } else {
          tr.innerHTML += `    
                  <td id="id">${data[i].id}</td>
                  <td>${data[i].street}</td>
                  <td>${data[i].streetNr}</td>
                  <td>${data[i].postCode}</td>
                  <td>${data[i].city}</td>
                  <td id="delete"></td>`;
        }
        table.appendChild(tr);
      });
    });
};

addRows();
