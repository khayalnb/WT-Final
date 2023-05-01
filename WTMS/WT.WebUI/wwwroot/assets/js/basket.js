////const minusBtn = $(".minus-btn");
////const plusBtn = $(".plus-btn");
////let productPrice = $(".count>span");
////let totolPriceBox = $("#total-price");
////let count = 1;

////plusBtn.click(() => {
////  count++;
////  productPrice.text(count);
////  totolPriceBox.text(parseInt( totolPriceBox.text())*count);
////});

////minusBtn.click(() => {
////  if (count > 1) {
////    count--;
////    productPrice.text(count);
////    totolPriceBox.text(parseInt( totolPriceBox.text())*count);
////  }
////});

function basketProductCount() {
    return getbasketStorageId().length;
}

function getbasketStorageId() {
    let items = JSON.parse(localStorage.getItem("basketItems"));
    if (items === null) {
        return []
    }
    return items;
}

let basketCount = document.getElementById("basket-count");
window.addEventListener("load", loadHeart);
function loadHeart() {
    console.log("is work")
    let productCountIDs = basketProductCount();
    basketCount.innerText = productCountIDs;

}

$(document).on("click", ".basket-btn", function (e) {
    e.preventDefault();
    const element = $(this)
    let productId = parseInt(element.attr("data-basket-id"));
    if (isNaN(productId)) return;
    let stringArr = localStorage.getItem("basketItems");
    let basketItems = (stringArr === null || stringArr === "" || typeof stringArr === "undefined") ? [] : JSON.parse(stringArr);

    if (!basketItems.some((item) => item.id === productId)) {
        basketItems.push({
            id: productId,
            count : 1
        });
        localStorage.setItem("basketItems", JSON.stringify(basketItems));
        //element.attr("src", "/assets/img/redHeart.svg");
        toastr.success("Səbətə əlavə edildi !");
        toastr.options.closeButton = true;
        let productCountIDs = basketProductCount();
        basketCount.innerText = productCountIDs;
    } else {
        for (var i = 0; i < basketItems.length; i++) {
            let element = basketItems[i];
            if (element.id === productId) {
                element.count = element.count + 1;
                break;
            }
        }
        localStorage.setItem("basketItems", JSON.stringify(basketItems));
        //element.attr("src", "/assets/img/heart.svg");
        //toastr.warning(" silindi!");
        toastr.options.closeButton = true;
        let productCountIDs = basketProductCount();
        basketCount.innerText = productCountIDs;
    }

})

