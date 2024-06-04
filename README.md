# Информационная система электронного журнала «ElectronicJournal».
### Название приложения: ElectronicJournal
### Описание приложения:
**Система «ElectronicJournal» предназначена для ведения и управления информацией о школьном/университетском учебном процессе. Она заменяет традиционные бумажные журналы и позволяет хранить и обрабатывать данные в электронном виде.**

# Функции, реализованные в программе:
1. **Ведение журнала посещаемости.** Присутствует возможноность занесения информации о присутствии/отсутствии учеников на уроках, пометка причин пропусков.
2. **Ввод и хранение оценок.** Занесение оценок по различным предметам и видам работ.
3. **Хранение учебного плана.** Занесение информации о предметах, учителях, расписании уроков.
4. **Генерация расписания.** Создание расписания уроков для отдельных классов или групп.
4. **Изменение расписания.** Возможность оперативного изменения расписания в случае необходимости.
4. **Создание и назначение домашних заданий.** Ввод информации о домашнем задании, сроке его выполнения.
5. **Проверка и оценка домашних заданий.** Возможность проверки выполнения заданий учителем, выставлять оценки.

# Технологии, которые были использованы для разработки приложения:
- **C#** - объектно-ориентированный язык программирования.
- **Visual Studio Community 2022** - интегрированная среда разработки (IDE), которая обеспечивает удобное создание, отладку и развертывание приложений.
- **Windows Presentation Foundation** - система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем, графическая подсистема в составе .NET Framework, использующая язык XAML.
- **Microsoft SQL Server** - система управления реляционными базами данных (РСУБД), разработанная корпорацией Microsoft.
- **Entity Framework** - это набор технологий в ADO.NET, которые поддерживают разработку программных приложений, ориентированных на данные.

# Описание базы данных:
#### Файл базы данных называется ElectronicJournal.bacpac <br/>
Файл базы данных расположен в проекте по пути **ElectronicJournal\ElectronicJournal\bin\Debug** </br>
В базе данных находятся 12 таблиц _Role_, _User_, _Student_, _Teacher_, _Class_, _Discipline_, _Homework_, _Assessment_, _Type_, _Pass_, _Schedule_, _Rating_.

- **Таблица «Role»** _(idRole, nameRole)_ содержит информацию о ролях
- **Таблица «User»** _(idUser, login, pass, idRole)_ содержит информацию о пользователях
- **Таблица «Student»** _(idStudent, nameStudent, surnameStudent, middleNameStudent, idUser, idClass)_ содержит информацию о студентах
- **Таблица «Teacher»** _(idTeacher, nameTeacher, surnameTeacher, middleNameTeacher, idDiscipline)_ содержит информацию о преподавателях
- **Таблица «Class»** _(idClass, nameClass)_ содержит информацию о классах
- **Таблица «Discipline»** _(idDiscipline, nameDiscipline)_ содержит информацию о дисциплинах
- **Таблица «Homework»** _(idHomework, idClass, idTeacher, task, deadline)_ содержит информацию о домашних заданиях
- **Таблица «Assessment»** _(idAssessment, idStudent, idDiscipline, mark, date, idType)_ содержит информацию об оценках
- **Таблица «Type»** _(idType, nameType)_ содержит информацию о типах пропусков/видов работ
- **Таблица «Pass»** _(idPass, idStudent, idType, data, idDiscipline)_ содержит информацию о пропусках
- **Таблица «Schedule»** _(idSchedule, idClass, day, idTeacher)_ содержит информацию о расписании
- **Таблица «Rating»** _(idRating, idDiscipline, assessment, idStudent)_ содержит информацию о средних оценок по предметам


# Скриншоты приложения:

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/MainWindow.png">
</br>Главная страница
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/Student.png">
</br>Окно студента
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/Teacher.png">
</br>Окно преподавателя
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/ListDisc.png">
</br>Список доступных дисциплин
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/edit.png">
</br>Редактирование журнала
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/listPass.png">
</br>Список посещаймости
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/Homework.png">
</br>Домашнее задание
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/schedule.png">
</br>Окно администратора
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/AddStudent.png">
</br>Добавление студента
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/AddTeacher.png">
</br>Добавление преподавателя
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/EditClass.png">
</br>Редактирование групп
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/EditDisc.png">
</br>Редактирование дисциплин
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/SheduleEdit.png">
</br>Добавление расписания
</br> </br> </br>
</p>
<h3>Видео</h3>

https://github.com/KristinaGurenkova/ElectronicJournal/blob/main/Screenshots/Video.mp4
