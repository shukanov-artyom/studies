// ������� ������� ��� �������� ������� ����������
function defineSubclass(superclass, // ����������� �����������
	constructor, // ����������� ������ ���������
	methods, // ������ �������.: ���������� � ��������
	statics) // �������� ������: ���������� � ������-�
	{
		// ���������� ������ - �������� ���������
		// ������� �������� - � ���������� �������� - ��������� ��������� �����������!
		constructor.prototype = inherit(superclass.prototype);
		// ���������� �������� "�����������" ���������
		constructor.prototype.constructor = constructor;
		// ����������� ������ methods � statics, ��� � ������ � �������� ��������
		if (methods) extend(constructor.prototype, methods);
		if (statics) extend(constructor, statics);
		// ������� �����
		return constructor;
	}
// �� �� ����� ����� ����������� � ���� ������ ������������ �����������
Function.prototype.extend = function(constructor, methods, statics) {
	return defineSubclass(this, constructor, methods, statics);
};