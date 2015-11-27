// Простая функция для создания простых подклассов
function defineSubclass(superclass, // Конструктор суперкласса
	constructor, // Конструктор нового подкласса
	methods, // Методы экземпл.: копируются в прототип
	statics) // Свойства класса: копируются в констр-р
	{
		// Установить объект - прототип подкласса
		// обратим внимание - у наследника прототип - наследник прототипа суперкласса!
		constructor.prototype = inherit(superclass.prototype);
		// выставляем свойство "конструктор" прототипа
		constructor.prototype.constructor = constructor;
		// Скопировать методы methods и statics, как в случае с обычными классами
		if (methods) extend(constructor.prototype, methods);
		if (statics) extend(constructor, statics);
		// Вернуть класс
		return constructor;
	}
// То же самое можно реализовать в виде метода конструктора суперкласса
Function.prototype.extend = function(constructor, methods, statics) {
	return defineSubclass(this, constructor, methods, statics);
};