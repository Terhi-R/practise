let form = document.querySelector(".form");
form.addEventListener("submit", toForm);

function toForm(str) {
  str.preventDefault();
  let newAddress = new FormData(form);
  console.log(...newAddress);
  let urlData = new URLSearchParams(newAddress);

  fetch("https://localhost:5000/api/Addresses", {
    method: "POST",
    headers: {
      "Content-Type": "application/x-www-form-urlencoded",
    },
    body: newAddress,
  })
    .then((response) => response.json())
    .then((data) => console.log(data))
    .catch((err) => console.log(err));
}

/*
    <form class="form">
      <div class="container">
        <div class="row">
          <label for="street">Street Name:</label>
          <input type="text" id="street" name="street" />
        </div>
        <div class="row">
          <label for="streetNr">Street Number:</label>
          <input type="number" id="streetNr" name="streetNr" />
        </div>
        <div class="row">
          <label for="postCode">Post Code:</label>
          <input type="number" id="postCode" name="postCode" />
        </div>
        <div class="row">
          <label for="city">City:</label>
          <input type="text" id="city" name="city" />
        </div>
        <div class="row submit">
          <button type="submit" id="submit">Add New Address</button>
        </div>
      </div>
    </form>
*/
