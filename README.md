# ShieldsIO

:v:Добавляйте в README шилды с нужной вам информацией.

:sweat_drops:Для этого достаточно перейти на https://mopin.ru/ и в конструкторе создать нужный вам шилд.

_______________

## :question: Как это работает? 

Разберём на примере создания шилда с размером GitHub репозитория ![AppVeyor](https://mopin.ru:/github/repo-size/Lizer-flesh/LazerMachine?logo=S)



**1. Выбираем нужный шилд:**
![image](https://user-images.githubusercontent.com/60391056/151194525-e104de30-e9ec-4f00-8a47-66f74f2e579d.png)

**2. При нажатии на него у нас появляется конструктор** 
![image](https://user-images.githubusercontent.com/60391056/151198295-710ba546-2ca1-45e0-9a4e-f15fda68036f.png)

**3. Вводим необходимые данные**
![image](https://user-images.githubusercontent.com/60391056/153894656-43cf845d-2847-4edc-a3d7-f13785f734f5.png)

**4. Копируем ссылку и вставляем в свой README в таком же формат**
![image](https://user-images.githubusercontent.com/60391056/153895847-0516dfc3-c372-4b03-989b-e967b737f0f3.png)

__________________

## :question: Как сделать шилд с версией юнити?


## Manuals (deprecated. use EnabledDeterminer)
Using the `ComponentIsActiveAndEnabledManual` manual, TabPoint is enabled for TabNavigation when the `isActiveAndEnabled` flag is set to true. 

You can define your manuals by inheriting from `TabPointEnabledManual`.

To set the default manual, click `Tools -> Tab Navigation -> Set Default All` or click `Set default enabled point manual` on a TabPoint that does not have the default manual installed.

## :question: How to use determiner?
In order to use the determiner you must have the `Use Determiner Definition` checkbox checked :white_check_mark:

If you have not yet selected a determiner, you will be prompted to use one. To do this, click on the `Use definition determiner (recommended)` button :point_up_2

Add the `Tab Point Enabled Determiner Definition` script and choose the value you want from the drop-down list.
__________________

The **default determiner** returns `tabPoint.isActiveAndEnabled`, which is a condition for the component to be Active and the script you added, which should be Enabled.
Also when set to Default, the component inherits the parent determiner, if any  :arrow_heading_up:

You can set **Determiner Asset**, where the `Enabled Determiner Asset` field accepts the scriptable object from the script you created.
The script must necessarily implement the **`ITabPointEnabledDeterminer` interface**.

If you select **Custom**, add your own script that implements the **`ITabPointEnabledDeterminer` interface** and uses the **`SetDeterminer` method**.


