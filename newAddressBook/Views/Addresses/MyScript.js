let addRow = document.querySelector(".newAddressForm");
addRow.addEventListener("click", addAddress());

function addAddress() {
  addRow.innerHTML =
    addRow +
    `                <tr><td>
                        Osoite
                    </td>
                    <td>
                        1
                    </td>
                    <td>
                        1234
                    </td>
                    <td>
                        Kaupunki
                    </td></tr>`;
}

addAddress();
