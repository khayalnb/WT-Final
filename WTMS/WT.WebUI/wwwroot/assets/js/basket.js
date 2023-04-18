const minusBtn = $(".minus-btn");
const plusBtn = $(".plus-btn");
let productPrice = $(".count>span");
let totolPriceBox = $("#total-price");
let count = 1;

plusBtn.click(() => {
  count++;
  productPrice.text(count);
  totolPriceBox.text(parseInt( totolPriceBox.text())*count);
});

minusBtn.click(() => {
  if (count > 1) {
    count--;
    productPrice.text(count);
    totolPriceBox.text(parseInt( totolPriceBox.text())*count);
  }
});
