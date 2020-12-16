use registration

create table UserNotes
(
id int NOT NULL IDENTITY(1,1),
title varchar(255),
icon varchar(50),
note_text text,
table_data text
)

truncate table UserNotes

insert into UserNotes values('Команда', 'sidemenu-icon-team', 'Какой-то длинный текст...', '')
insert into UserNotes values('Задачи', 'sidemenu-icon-tasks', 'Какой-то длинный текст...', '')
insert into UserNotes values('Users Feedback', 'sidemenu-icon-ux', 'Какой-то длинный текст...', '')
insert into UserNotes values('Заметки встреч', 'sidemenu-icon-meetingNotes', 'Какой-то длинный текст...', '')

insert into UserNotes values('Презентации&Отчеты', 'sidemenu-icon-reports', 'Какой-то длинный текст...', '')
insert into UserNotes values('Roadmap', 'sidemenu-icon-roadmap', 'Какой-то длинный текст...', '')
insert into UserNotes values('Insights&Memos', 'sidemenu-icon-insights', 'Какой-то длинный текст...', '')

select * from UserNotes

/* тестил обновление заметки */
UPDATE UserNotes
SET title = 'Insights&Memos', icon = 'sidemenu-icon-insights', note_text = 'The following SQL statement updates the first customer (CustomerID = 1) with a new contact person and a new city.'
WHERE id = 7;