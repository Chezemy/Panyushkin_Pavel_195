Version Control System(VCS; Система контроля версий) - место, где хранятся и поддерживаются какие-либо данные.<br>
Git — система управления версиями с распределенной архитектурой, абсолютный лидер по популярности среди современных систем управления версиями.Это развитый проект с активной поддержкой и открытым исходным кодом. Система Git была изначально разработана в 2005 году Линусом Торвальдсом — создателем ядра операционной системы Linux. Git применяется для управления версиями в рамках колоссального количества проектов по разработке ПО, как коммерческих, так и с открытым исходным кодом. Система используется множеством профессиональных разработчиков программного обеспечения. Она превосходно работает под управлением различных операционных систем и может применяться со множеством интегрированных сред разработки (IDE).<br>
В отличие от некогда популярных систем вроде CVS и Subversion (SVN), где полная история версий проекта доступна лишь в одном месте, в Git каждая рабочая копия кода сама по себе является репозиторием. Это позволяет всем разработчикам хранить историю изменений в полном объеме.<br>
    <h3>Создание нового репозитория:</h3>
<b>$ mkdir Desktop/git_exercise/<br>
$ cd Desktop/git_exercise/<br>
$ git init</b><br>

<h3>Определение состояния</h3>
status — это еще одна важнейшая команда, которая показывает информацию о текущем состоянии репозитория: актуальна ли информация на нём, нет ли чего-то нового, что поменялось, и так далее.

<b>$ git status<br>
On branch master<br>
Initial commit<br>
Untracked files:<br>
(use "git add ..." to include in what will be committed)<br>
hello.txt</b><br>

Сообщение говорит о том, что файл hello.txt неотслеживаемый. Это значит, что файл новый и система еще не знает, нужно ли следить за изменениями в файле или его можно просто игнорировать. Для того, чтобы начать отслеживать новый файл, нужно его специальным образом объявить.
<h3>Подготовка файлов</h3>
В git есть концепция области подготовленных файлов. Можно представить ее как холст, на который наносят изменения, которые нужны в коммите. Сперва он пустой, но затем мы добавляем на него файлы (или части файлов, или даже одиночные строчки) командой add и, наконец, коммитим все нужное в репозиторий (создаем слепок нужного нам состояния) командой commit.
В нашем случае у нас только один файл, так что добавим его:<br>
<b>$ git add hello.txt</b><br>
Если нам нужно добавить все, что находится в директории, мы можем использовать<br>
<b>$ git add -A</b><br>
Проверим статус снова, на этот раз мы должны получить другой ответ:<br>

<b>$ git status<br>
On branch master<br>
Initial commit<br>
Changes to be committed:<br>
(use "git rm --cached ..." to unstage)<br>
new file: hello.txt</b><br>

Файл готов к коммиту. Сообщение о состоянии также говорит нам о том, какие изменения относительно файла были проведены в области подготовки — в данном случае это новый файл, но файлы могут быть модифицированы или удалены.

<h3>Коммит(фиксация изменений)</h3>
Коммит представляет собой состояние репозитория в определенный момент времени. Это похоже на снапшот, к которому мы можем вернуться и увидеть состояние объектов на определенный момент времени.
Чтобы зафиксировать изменения, нам нужно хотя бы одно изменение в области подготовки (мы только что создали его при помощи git add), после которого мы может коммитить:<br>
<b>$ git commit -m "Initial commit."</b><br>

Эта команда создаст новый коммит со всеми изменениями из области подготовки (добавление файла hello.txt). Ключ -m и сообщение «Initial commit.» — это созданное пользователем описание всех изменений, включенных в коммит. Считается хорошей практикой делать коммиты часто и всегда писать содержательные комментарии.

<h3>Удаленные репозитории</h3>
Сейчас наш коммит является локальным — существует только в директории .git на нашей файловой системе. Несмотря на то, что сам по себе локальный репозиторий полезен, в большинстве случаев мы хотим поделиться нашей работой или доставить код на сервер, где он будет выполняться.

<h2>Ветвление</h2>
Во время разработки новой функциональности считается хорошей практикой работать с копией оригинального проекта, которую называют веткой. Ветви имеют свою собственную историю и изолированные друг от друга изменения до тех пор, пока вы не решаете слить изменения вместе. Это происходит по набору причин:
<ul>
<li>Уже рабочая, стабильная версия кода сохраняется.</li>
<li>Различные новые функции могут разрабатываться параллельно разными программистами.</li>
<li>Разработчики могут работать с собственными ветками без риска, что кодовая база поменяется из-за чужих изменений.</li>
<li>В случае сомнений, различные реализации одной и той же идеи могут быть разработаны в разных ветках и затем сравниваться.</li>
</ul>

<h3>1. Создание новой ветки</h3>
Основная ветка в каждом репозитории называется master. Чтобы создать еще одну ветку, используем команду branch <name><br>
  <b>$ git branch amazing_new_feature</b><br>
Это создаст новую ветку, пока что точную копию ветки master.
  
  <h3>2. Переключение между ветками</h3>
Сейчас, если мы запустим branch, мы увидим две доступные опции:<br>
<b>$ git branch<br>
amazing_new_feature<br>
  * master</b><br>
master — это активная ветка, она помечена звездочкой. Но мы хотим работать с нашей “новой потрясающей фичей”, так что нам понадобится переключиться на другую ветку. Для этого воспользуемся командой checkout, она принимает один параметр — имя ветки, на которую необходимо переключиться.<br>
  <b>$ git checkout amazing_new_feature</b><br>
  
  <h3>3. Слияние веток</h3>
Наша “потрясающая новая фича” будет еще одним текстовым файлом под названием feature.txt. Мы создадим его, добавим и закоммитим:
<b>$ git add feature.txt<br>
   $ git commit -m "New feature complete.”</b><br>
Изменения завершены, теперь мы можем переключиться обратно на ветку master.
  <b>$ git checkout master</b><br>
Теперь, если мы откроем наш проект в файловом менеджере, мы не увидим файла feature.txt, потому что мы переключились обратно на ветку master, в которой такого файла не существует. Чтобы он появился, нужно воспользоваться merge для объединения веток (применения изменений из ветки amazing_new_feature к основной версии проекта).<br>
  <b>$ git merge amazing_new_feature</b><br>
Теперь ветка master актуальна. Ветка amazing_new_feature больше не нужна, и ее можно удалить.<br>
  <b>$ git branch -d awesome_new_feature</b><br><br><br>  
  
    <b>$git init</b>  -  Инициализация репозитория
    <b>$git status</b>  -  Узнать изменения в репозитории
    <b>$git add</b>  -  Добавление в индекс всех файлов, в которых были изменения, а также новые файлы
    <b>$git commit -m "first commit"</b>  -  совершение коммита(сохранение изменений)
    <b>$git remote add origin https://github.com/(Username)/(RepositoryName).git</b>  -  Подключение к удаленному репозиторию
    <b>$git push https://(Username):(Token)@github.com/(Username)/(RepositoryName).git</b>  -  Отправка локальной ветки в удаленный репозиторий
