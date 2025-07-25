const dialog = document.getElementById("dialog");
const showBtn = document.querySelector(".show");
const closeBtn = document.querySelector(".close");

showBtn.addEventListener("click", () => {
    dialog.showModal();
});

closeBtn.addEventListener("click",  () =>  {
    dialog.close();
});