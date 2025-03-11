const menuActive = document.querySelector('.menu'); // Открыть список 
const burger = document.querySelector('.header_menu_right__menu'); // Открытие страницы 
// const MenuClose = document.querySelector('.menu-close'); // Открытие экрана 

function toggleMenu() { 
	menuActive.classList.toggle('hidden'); //Функция удаляет или устанавливает класс с названием 'hidden' div с классом .menu-active 
} 

burger.addEventListener('click', toggleMenu); // Открытие меню 
// MenuClose.addEventListener ('click', toggleMenu); // По клику на крестик срабатывает функция