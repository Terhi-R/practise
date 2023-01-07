// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
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
