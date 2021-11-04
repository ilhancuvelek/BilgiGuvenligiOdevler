const inputs = document.querySelectorAll(".input");
inputs.forEach((element) => {
  element.addEventListener("mouseover", function () {
    element.style.backgroundColor = "yellow";
  });
  element.addEventListener("mouseout", function () {
    element.style.backgroundColor = "white";
  });
});
const src = [
  {
    link: "img/deneme.png",
    content: "ABx9y",
  },
  {
    link: "img/deneme2.png",
    content: "TxG7aZ",
  },
  {
    link: "img/captcha.png",
    content: "PRNU",
  },
];
var index = 0;
let img = document.getElementById("captchaa");
let p = document.getElementById("image");
p.innerHTML = `<img src='${src[index].link}' width='200px' name='capt' id='captchaa'>`;
let text = src[index].content;
document.getElementById("submit").addEventListener("click", function () {
  inputs.forEach((element) => {
    if (element.classList.contains("captch")) {
      if (element.value === text) {
        alert("giriş başarılı");
        index++
        if (index >= src.length) {
          index=0;
        }
        p.innerHTML = `<img src='${src[index].link}' width='200px' name='capt' id='captchaa'>`;
        
        inputs.forEach(element => {
          element.value=""
      });
      } else {
        alert("hatalı giriş");
        if (confirm("contiune?")) {
            inputs.forEach(element => {
                element.value=""
            });
          index++;
          if (index >= src.length) {
            index=0;
          }
          p.innerHTML = `<img src='${src[index].link}' width='200px' name='capt' id='captchaa'>`;
          
          //   img.setAttribute("src", src[index].link);
        }
      }
    }
  });
});
// const worker = new Tesseract.TesseractWorker();
// worker
// .recognize(
//   'img/captcha.png',
//   'eng+tur'
// )
// .progress((p) => {
//   console.log('progress', p);
// })
// .then((result) => {
//   console.log(result);
// });