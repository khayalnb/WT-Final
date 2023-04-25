function LikeProductCount() {
    return getLocalStorageId().length;
}

function getLocalStorageId() {
    let items = JSON.parse(localStorage.getItem("likedProductIds"));
    if (items === null) {
        return []
    }
    return items;
}

let likeCount = document.getElementById("like-count");
window.addEventListener("load", loadHeart);
function loadHeart() {
    console.log("is work")
    let productCountIDs = LikeProductCount();
    likeCount.innerText = productCountIDs;

    let likedProductIds = getLocalStorageId();
    $.each($(".like-btn"), function (key, product) {
        let item = $(this);
        if (likedProductIds.includes(parseInt(item.attr("data-heart-id")))) {
            item.attr("src", "/assets/img/redHeart.svg");
        }
    })
}

$(document).on("click", ".like-btn", function (e) {
    e.preventDefault();
    const element = $(this)
    let productId = parseInt(element.attr("data-heart-id"));
    if (isNaN(productId)) return;
    let stringArr = localStorage.getItem("likedProductIds");
    let likedProductIds = (stringArr === null || stringArr === "" || typeof stringArr === "undefined") ? [] : JSON.parse(stringArr);

    if (!likedProductIds.includes(productId)) {
        likedProductIds.push(productId);
        localStorage.setItem("likedProductIds", JSON.stringify(likedProductIds));
        element.attr("src", "/assets/img/redHeart.svg");
        toastr.success("Bəyənilənlərə əlavə edildi !");
        toastr.options.closeButton = true;
        let productCountIDs = LikeProductCount();
        likeCount.innerText = productCountIDs;
    } else {
        likedProductIds = likedProductIds.filter(id => id !== productId);
        localStorage.setItem("likedProductIds", JSON.stringify(likedProductIds));
        element.attr("src", "/assets/img/heart.svg");
        toastr.warning("Bəyənilənlərdən silindi!");
        toastr.options.closeButton = true;
        let productCountIDs = LikeProductCount();
        likeCount.innerText = productCountIDs;
    }

})