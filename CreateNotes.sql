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

insert into UserNotes values('�������', 'sidemenu-icon-team', '�����-�� ������� �����...', '')
insert into UserNotes values('������', 'sidemenu-icon-tasks', '�����-�� ������� �����...', '')
insert into UserNotes values('Users Feedback', 'sidemenu-icon-ux', '�����-�� ������� �����...', '')
insert into UserNotes values('������� ������', 'sidemenu-icon-meetingNotes', '�����-�� ������� �����...', '')

insert into UserNotes values('�����������&������', 'sidemenu-icon-reports', '�����-�� ������� �����...', '')
insert into UserNotes values('Roadmap', 'sidemenu-icon-roadmap', '�����-�� ������� �����...', '')
insert into UserNotes values('Insights&Memos', 'sidemenu-icon-insights', '�����-�� ������� �����...', '')

select * from UserNotes

/* ������ ���������� ������� */
UPDATE UserNotes
SET title = 'Insights&Memos', icon = 'sidemenu-icon-insights', note_text = 'The following SQL statement updates the first customer (CustomerID = 1) with a new contact person and a new city.'
WHERE id = 7;