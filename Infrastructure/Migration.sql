create table students
(
    students_id serial primary key,
    students_code varchar,
    stdeunt_dull_name varchar,
    gender varchar,
    dob date,
    email varchar,
    phone varchar,
    school_id int references school(school_id),
    stage int,
    section char,
    is_active int,
    join_date date,
    created_at date,
    updated_at date
);


create table school
(
    school_id serial primary key,
    school_title varchar,
    level_count int,
    is_active int,
    created_at date,
    updated_at date
);

create table parents
(
    parent_id serial primary key,
    parent_code varchar,
    parent_full_name varchar,
    email varchar,
    phone varchar,
    created_at date,
    updated_at date
);

create table student_parent
(
    student_parent_id serial primary key,
    student_id int references students(students_id),
    parent_id int references parents(parent_id),
    relationship int
);

create table class
(
    class_id serial primary key,
    class_name varchar,
    subject_id int references subject(subject_id),
    teacher_id int references teacher(teacher_id),
    classroom_id int references classroom(classrom_id),
    section varchar,
    created_at date,
    updated_at date
);

create table classroom
(
    classrom_id serial primary key,
    capacity_id int,
    room_type int,
    description varchar,
    created_at date,
    updated_at date
);

create table class_student
(
    class_students_id serial primary key,
    class_id int references class(class_id),
    student_id int references students(students_id)
);

create table subject
(
    subject_id serial primary key,
    title varchar,
    school_id int references school(school_id),
    stage int,
    term int,
    carry_mark int,
    created_at date,
    updated_at date
);

create table teacher
(
    teacher_id serial primary key,
    teacher_code varchar,
    gender varchar,
    dob date,
    email varchar,
    phone varchar,
    is_active int,
    join_date date,
    working_days int,
    created_at date,
    updated_at date
);