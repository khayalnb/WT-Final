const categoryBtn = document.getElementsByClassName("wt-category")[0],
  categoryMenu = document.getElementsByClassName("category-box")[0],
  sliderBox = document.getElementsByClassName("width-change-box");

categoryBtn.addEventListener("click", function () {
  categoryMenu.classList.toggle("active");
  [...sliderBox].forEach((item) => {
    item.classList.remove("col-sm-12");
    item.classList.toggle("col-sm-11");
    item.classList.toggle("ps-4");
  });
});

const heartBox = document.getElementsByClassName("heart-box");

//[...heartBox].forEach((item) => {
//  item.addEventListener("click", function () {
//    if (this.children[0].dataset.like == 1) {
//      this.children[0].src = "assets/img/redHeart.svg";
//      this.children[0].dataset.like = 2;
//    } else {
//      this.children[0].src = "assets/img/heart.svg";
//      this.children[0].dataset.like = 1;
//    }
//  });
//});







