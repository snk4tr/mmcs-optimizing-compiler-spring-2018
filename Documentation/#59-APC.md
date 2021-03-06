### Название задачи
Проверка CFG на приводимость
#### Постановка задачи
Необходимо проверить CFG на приводимость
#### Зависимости задач в графе задач
Зависит от:
* Классификация ребер CFG по Глубинному остовному дереву
* Дерево доминаторов

#### Теоретическая часть задачи
Алгоритм проверки основан на следующей теореме:
##### Теорема о приводимости графа потока управления:
Граф потока управления является приводимым, если для любого глубинного остовного дерева 
этого графа все отступающие(retreating) ребра являются обратными(back).

#### Практическая часть задачи (реализация)
Алгоритм проверки CFG на приводимость:
* Получить список всех отсупающих(retreating) ребер CFG по Глубинному остовномоу дереву
* Построить дерево доминаторов
* Проверить, что конец всех отступающих ребер доминирует над их началом с помощью дерева доминаторов

#### Пример работы.
Исходный код программы с неприводимым CFG:
```csharp
if (1 < -3)
  a = 123;
else
  goto h;
b = 777;
for(i = 0, 10)
{
 print(1 >= 3);
 h: {c = a + b;}
 if (1 + 3)
 {
   a = 1;
 }
}
```
Ответ: false.

Исходный код программы с приводимым CFG:
```csharp
a = 2;
while(3)
{
  b = 10;
  goto h;
}
for(i = 0, 10, 1 + 1)
 print(1,2,3);
h: {c = a + b;}
for(i = 0, 10)
{
 print(1 >= 3);
 if (1 + 3)
 {
   a = 1;
 }
}
```
Ответ: true.


