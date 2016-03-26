CREATE TABLE `teacher` (

`teacher_id` int(11) NOT NULL AUTO_INCREMENT,

`teacher_username` varchar(255) NULL,

`teacher_name` varchar(255) NULL,

`teacher_surname` varchar(255) NULL,

`teacher_password` varchar(60) NULL,

`teacher_email` varchar(255) NULL,

`teacher_msgr_id` int(11) NULL,

PRIMARY KEY (`teacher_id`) 

);



CREATE TABLE `courseAnnouncements` (

`courseAnnouncements_id` int(11) NOT NULL AUTO_INCREMENT,

`courseAnnouncements_teacher_id` int(11) NULL,

`courseAnnouncements_course_id` int(11) NULL,

`courseAnnouncements_title` varchar(255) NULL,

`courseAnnouncements_msg` longtext NULL,

`courseAnnouncements_time` datetime NULL ON UPDATE CURRENT_TIMESTAMP,

PRIMARY KEY (`courseAnnouncements_id`) 

);



CREATE TABLE `student` (

`student_id` int(11) NOT NULL AUTO_INCREMENT,

`student_username` varchar(255) NULL,

`student_name` varchar(255) NULL,

`student_surname` varchar(255) NULL,

`student_password` varchar(60) NULL,

`student_gpa` float(4,0) NULL,

`student_email` varchar(255) NULL,

`student_department_id` int(11) NULL,

`student_national_id` int(11) NULL,

`student_financialAffairs_id` int(11) NULL,

`student_advisor_id` int(11) NULL,

`student_msgr_id` int(11) NULL,

PRIMARY KEY (`student_id`) 

);



CREATE TABLE `department` (

`department_id` int(11) NOT NULL AUTO_INCREMENT,

`department_name` varchar(255) NULL,

`department_number_of_students` int(11) NULL,

PRIMARY KEY (`department_id`) 

);



CREATE TABLE `slot` (

`slot_id` int(11) NOT NULL AUTO_INCREMENT,

`slot_student_id` int(11) NULL,

`slot_course_id` int(11) NULL,

`slot_result` varchar(255) NULL,

PRIMARY KEY (`slot_id`) 

);



CREATE TABLE `events` (

`events_id` int(11) NOT NULL AUTO_INCREMENT,

`events_name` varchar(255) NULL,

`events_info` longtext NULL,

`events_organizer` varchar(255) NULL,

`events_place` varchar(255) NULL,

`events_time` datetime NULL ON UPDATE CURRENT_TIMESTAMP,

PRIMARY KEY (`events_id`) 

);



CREATE TABLE `msgr` (

`msgr_id` int(11) NOT NULL AUTO_INCREMENT,

`msgr_name` varchar(255) NULL,

PRIMARY KEY (`msgr_id`) 

);



CREATE TABLE `studentSchedule` (

`studentSchedule_id` int(11) NOT NULL AUTO_INCREMENT,

`studentSchedule_student_id` int(11) NULL,

`studentSchedule_teacher_id` int(11) NULL,

`studentSchedule_course_id` int(11) NULL,

`studentSchedule_section_id` int(11) NULL,

PRIMARY KEY (`studentSchedule_id`) 

);



CREATE TABLE `Announcements` (

`Announcements_id` int(11) NOT NULL AUTO_INCREMENT,

`Announcements_title` varchar(255) NULL,

`Announcements_msg` longtext NULL,

PRIMARY KEY (`Announcements_id`) 

);



CREATE TABLE `sectionTime` (

`sectionTime_id` int(11) NOT NULL AUTO_INCREMENT,

`sectionTime_section_id` int(11) NULL,

`sectionTime_time` int(3) NULL,

PRIMARY KEY (`sectionTime_id`) 

);



CREATE TABLE `course` (

`course_id` int(11) NOT NULL AUTO_INCREMENT,

`course_department_id` int(11) NULL,

`course_name` varchar(255) NULL,

`course_code` varchar(255) NULL,

`course_info` longtext NULL,

PRIMARY KEY (`course_id`) 

);



CREATE TABLE `exam` (

`exam_id` int(11) NOT NULL AUTO_INCREMENT,

`exam_course_id` int(11) NULL,

`exam_time` varchar(255) NULL,

`exam_place` varchar(255) NULL,

PRIMARY KEY (`exam_id`) 

);



CREATE TABLE `section` (

`section_id` int(11) NOT NULL AUTO_INCREMENT,

`section_course_id` int(11) NULL,

`section_number` int(3) NULL,

`section_teacher_id` int(11) NULL,

PRIMARY KEY (`section_id`) 

);



CREATE TABLE `financialAffairs` (

`financialAffairs_id` int(11) NOT NULL AUTO_INCREMENT,

`financialAffairs_paid` int(20) NULL,

`financialAffairs_rest` int(20) NULL,

PRIMARY KEY (`financialAffairs_id`) 

);



CREATE TABLE `msg` (

`msg_id` int(11) NOT NULL AUTO_INCREMENT,

`msg_sender_id` int(11) NULL,

`msg_receiver_id` int(11) NULL,

`msg_time` datetime NULL ON UPDATE CURRENT_TIMESTAMP,

`msg_title` varchar(255) NULL,

`msg_message` varchar(255) NULL,

`msg_file_name` varchar(255) NULL,

PRIMARY KEY (`msg_id`) 

);



CREATE TABLE `manager` (

`manager_id` int(11) NOT NULL AUTO_INCREMENT,

`manager_username` varchar(255) NULL,

`manager_password` varchar(255) NULL,

PRIMARY KEY (`manager_id`) 

);





ALTER TABLE `courseAnnouncements` ADD CONSTRAINT `teacher_courseAnnouncements` FOREIGN KEY (`courseAnnouncements_teacher_id`) REFERENCES `teacher` (`teacher_id`);

ALTER TABLE `student` ADD CONSTRAINT `studentAdvisor` FOREIGN KEY (`student_advisor_id`) REFERENCES `teacher` (`teacher_id`);

ALTER TABLE `courseAnnouncements` ADD CONSTRAINT `course_courseAnnouncements` FOREIGN KEY (`courseAnnouncements_course_id`) REFERENCES `course` (`course_id`);

ALTER TABLE `studentSchedule` ADD CONSTRAINT `student_studentSchedule` FOREIGN KEY (`studentSchedule_student_id`) REFERENCES `student` (`student_id`);

ALTER TABLE `studentSchedule` ADD CONSTRAINT `teacher_studentSchedule` FOREIGN KEY (`studentSchedule_teacher_id`) REFERENCES `teacher` (`teacher_id`);

ALTER TABLE `studentSchedule` ADD CONSTRAINT `course_studentSchedule` FOREIGN KEY (`studentSchedule_course_id`) REFERENCES `course` (`course_id`);

ALTER TABLE `studentSchedule` ADD CONSTRAINT `section_studentSchedule` FOREIGN KEY (`studentSchedule_section_id`) REFERENCES `section` (`section_id`);

ALTER TABLE `course` ADD CONSTRAINT `department_course` FOREIGN KEY (`course_department_id`) REFERENCES `department` (`department_id`);

ALTER TABLE `section` ADD CONSTRAINT `course_section` FOREIGN KEY (`section_course_id`) REFERENCES `course` (`course_id`);

ALTER TABLE `section` ADD CONSTRAINT `teacher_section` FOREIGN KEY (`section_teacher_id`) REFERENCES `teacher` (`teacher_id`);

ALTER TABLE `student` ADD CONSTRAINT `department_student` FOREIGN KEY (`student_department_id`) REFERENCES `department` (`department_id`);

ALTER TABLE `student` ADD CONSTRAINT `finance_student` FOREIGN KEY (`student_financialAffairs_id`) REFERENCES `financialAffairs` (`financialAffairs_id`);

ALTER TABLE `student` ADD CONSTRAINT `msgr_student` FOREIGN KEY (`student_msgr_id`) REFERENCES `msgr` (`msgr_id`);

ALTER TABLE `msg` ADD CONSTRAINT `sender_msg` FOREIGN KEY (`msg_sender_id`) REFERENCES `msgr` (`msgr_id`);

ALTER TABLE `msg` ADD CONSTRAINT `receiver_msg` FOREIGN KEY (`msg_receiver_id`) REFERENCES `msgr` (`msgr_id`);

ALTER TABLE `exam` ADD CONSTRAINT `course_exam` FOREIGN KEY (`exam_course_id`) REFERENCES `course` (`course_id`);

ALTER TABLE `slot` ADD CONSTRAINT `student_slot` FOREIGN KEY (`slot_student_id`) REFERENCES `student` (`student_id`);

ALTER TABLE `slot` ADD CONSTRAINT `course_slot` FOREIGN KEY (`slot_course_id`) REFERENCES `course` (`course_id`);

ALTER TABLE `sectionTime` ADD CONSTRAINT `section_sectionTime` FOREIGN KEY (`sectionTime_section_id`) REFERENCES `section` (`section_id`);



