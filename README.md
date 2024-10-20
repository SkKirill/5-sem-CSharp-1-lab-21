### Скоморохов Кирилл | 8 (900) 988-75-37 | Т-Банк | tg = @sk_kiriII | vk = sk_kirill | VisualStudia | C#

> **1500₽**

# Задача 21  

> Найти группы, в которых обучаются только студенты бюджетной формы обучения.

**Требования.**  
Структура записи файла с информацией о студентах:
- ФИО;
- номер курса;
- номер группы;
- успеваемость — 4 экзамена в каждой из 8 сессий;
- форма обучения (бюджетная, договорная).  

**Экзамен:**  
- наименование предмета,
- оценка.  

Создать GUI приложение, **выполняющее следующие функции:**
- Создать новый файл.
- Открыть существующий файл (в формате XML, двоичном или
- текстовом формате).
- Сохранить файл (в формате XML, двоичном или текстовом формате).
- Вывести файл.
- Добавить запись.
- Изменить запись.
- Выполнить вариант задания.  

> Информацию об одном студенте и методы ее обработки оформить в отдельном классе. Для сохранения и считывания XML и двоичного файла использовать стандартную сериализацию.
> Компоненты графического интерфейса используются только для отображения, а обработка выполняется с использованием внутренних структур данных. Для сериализации в различные
> форматы файлов реализовать различные классы на основе интерфейса:
``` CSharp
public interface IFileProcessor
 {
 List<students> Load(string filename);
 void Save(string filename, List<students> students);
 }
```
В зависимости от выбранного при сохранении расширения файла,
присваивать переменной IFileProcessor processor объект соответствующего класса. Использовать processor для сохранения и чтения информации
из файла.

# Структура проекта

```
Comparable-Mark/
├── Models/
│   ├── Session.cs
│   ├── FormEducation.cs
│   ├── Student.cs
│   └── Exam.cs
├── FileProcessors/
│   ├── FileProcessorXML.cs
│   ├── FileProcessorDat.cs
│   ├── FileProcessorTxt.cs
│   └── IFileProcessor.cs
├── Forms/
│   ├── State.cs
│   ├── InputForm.cs
│   ├── MainDataForm.cs
│   ├── EditStudentForm.cs
│   └── TaskForm.cs
└──  Program.cs
```

# Примечания 
