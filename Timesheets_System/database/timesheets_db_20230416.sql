--
-- PostgreSQL database dump
--

-- Dumped from database version 11.14
-- Dumped by pg_dump version 11.14

-- Started on 2023-04-16 22:10:11

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 206 (class 1255 OID 28059)
-- Name: update_time_when_duplicate_username_and_date(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_time_when_duplicate_username_and_date() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
	IF EXISTS (SELECT * FROM Timesheets_details_tb t WHERE NEW.Fullname = t.Fullname AND NEW.Date = t.Date) THEN
		UPDATE Timesheets_details_tb
		SET Checkin = NEW.Checkin, Checkout = NEW.Checkout, Working_Hours = NEW.Working_Hours
		WHERE Timesheets_details_tb.Fullname = NEW.Fullname AND Timesheets_details_tb.Date = NEW.Date;
	ELSE
		INSERT INTO Timesheets_details_tb (Fullname, Date, Checkin, Checkout, Working_Hours)
		VALUES (NEW.Fullname, NEW.Date, NEW.Checkin, NEW.Checkout, NEW.Working_Hours);
	END IF;
	RETURN NULL;
END;
$$;


ALTER FUNCTION public.update_time_when_duplicate_username_and_date() OWNER TO postgres;

--
-- TOC entry 219 (class 1255 OID 28026)
-- Name: update_total_working_hours_and_days(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_total_working_hours_and_days() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
BEGIN
    NEW.total_working_hours := COALESCE(NEW.D1, 0) + COALESCE(NEW.D2, 0) + COALESCE(NEW.D3, 0) + COALESCE(NEW.D4, 0) + COALESCE(NEW.D5, 0) + COALESCE(NEW.D6, 0) + COALESCE(NEW.D7, 0) + 
    COALESCE(NEW.D8, 0) + COALESCE(NEW.D9, 0) + COALESCE(NEW.D10, 0) + COALESCE(NEW.D11, 0) + COALESCE(NEW.D12, 0) + COALESCE(NEW.D13, 0) + COALESCE(NEW.D14, 0) + COALESCE(NEW.D15, 0) + 
    COALESCE(NEW.D16, 0) + COALESCE(NEW.D17, 0) + COALESCE(NEW.D18, 0) + COALESCE(NEW.D19, 0) + COALESCE(NEW.D20, 0) + COALESCE(NEW.D21, 0) + COALESCE(NEW.D22, 0) + COALESCE(NEW.D23, 0) + 
    COALESCE(NEW.D24, 0) + COALESCE(NEW.D25, 0) + COALESCE(NEW.D26, 0) + COALESCE(NEW.D27, 0) + COALESCE(NEW.D28, 0) + COALESCE(NEW.D29, 0) + COALESCE(NEW.D30, 0) + COALESCE(NEW.D31, 0);
    NEW.total_working_days := (CASE WHEN NEW.d1 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d2 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d3 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d4 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d5 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d6 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d7 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d8 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d9 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d10 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d11 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d12 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d13 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d14 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d15 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d16 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d17 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d18 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d19 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d20 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d21 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d22 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d23 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d24 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d25 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d26 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d27 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d28 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d29 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d30 > 0 THEN 1 ELSE 0 END) + (CASE WHEN NEW.d31 > 0 THEN 1 ELSE 0 END);
    RETURN NEW;
END;
END;$$;


ALTER FUNCTION public.update_total_working_hours_and_days() OWNER TO postgres;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 201 (class 1259 OID 27975)
-- Name: auth_group_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.auth_group_tb (
    auth_group_id character varying(20) NOT NULL,
    auth_group_name character varying(50)
);


ALTER TABLE public.auth_group_tb OWNER TO postgres;

--
-- TOC entry 197 (class 1259 OID 27947)
-- Name: department_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.department_tb (
    department_id character varying(20) NOT NULL,
    department_name character varying(50)
);


ALTER TABLE public.department_tb OWNER TO postgres;

--
-- TOC entry 199 (class 1259 OID 27957)
-- Name: member_of_team_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.member_of_team_tb (
    team_id character varying(20) NOT NULL,
    member_id character varying(50) NOT NULL,
    "position" character varying(20)
);


ALTER TABLE public.member_of_team_tb OWNER TO postgres;

--
-- TOC entry 202 (class 1259 OID 27980)
-- Name: screen_auth_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.screen_auth_tb (
    auth_group_id character varying(20) NOT NULL,
    screen_id character varying(30) NOT NULL,
    allowed_to_open character varying(1)
);


ALTER TABLE public.screen_auth_tb OWNER TO postgres;

--
-- TOC entry 200 (class 1259 OID 27970)
-- Name: screen_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.screen_tb (
    screen_id character varying(30) NOT NULL,
    screen_name character varying(100)
);


ALTER TABLE public.screen_tb OWNER TO postgres;

--
-- TOC entry 198 (class 1259 OID 27952)
-- Name: team_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.team_tb (
    team_id character varying(20) NOT NULL,
    department_id character varying(20),
    team_name character varying(50)
);


ALTER TABLE public.team_tb OWNER TO postgres;

--
-- TOC entry 204 (class 1259 OID 28047)
-- Name: timesheets_details_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.timesheets_details_tb (
    username character varying(50) NOT NULL,
    fullname character varying(100) NOT NULL,
    date date NOT NULL,
    checkin timestamp without time zone,
    checkout timestamp without time zone,
    working_hours numeric(4,1)
);


ALTER TABLE public.timesheets_details_tb OWNER TO postgres;

--
-- TOC entry 205 (class 1259 OID 28056)
-- Name: timesheets_raw_data_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.timesheets_raw_data_tb (
    fullname character varying(100),
    in_out_time timestamp without time zone
);


ALTER TABLE public.timesheets_raw_data_tb OWNER TO postgres;

--
-- TOC entry 203 (class 1259 OID 28015)
-- Name: timesheets_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.timesheets_tb (
    username character varying(50) NOT NULL,
    fullname character varying(100),
    year integer NOT NULL,
    month integer NOT NULL,
    d1 numeric(3,1),
    d2 numeric(3,1),
    d3 numeric(3,1),
    d4 numeric(3,1),
    d5 numeric(3,1),
    d6 numeric(3,1),
    d7 numeric(3,1),
    d8 numeric(3,1),
    d9 numeric(3,1),
    d10 numeric(3,1),
    d11 numeric(3,1),
    d12 numeric(3,1),
    d13 numeric(3,1),
    d14 numeric(3,1),
    d15 numeric(3,1),
    d16 numeric(3,1),
    d17 numeric(3,1),
    d18 numeric(3,1),
    d19 numeric(3,1),
    d20 numeric(3,1),
    d21 numeric(3,1),
    d22 numeric(3,1),
    d23 numeric(3,1),
    d24 numeric(3,1),
    d25 numeric(3,1),
    d26 numeric(3,1),
    d27 numeric(3,1),
    d28 numeric(3,1),
    d29 numeric(3,1),
    d30 numeric(3,1),
    d31 numeric(3,1),
    total_working_days numeric(3,1),
    total_working_hours numeric(4,1)
);


ALTER TABLE public.timesheets_tb OWNER TO postgres;

--
-- TOC entry 196 (class 1259 OID 24081)
-- Name: user_tb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.user_tb (
    username character varying(50) NOT NULL,
    password character varying(50),
    fullname character varying(50),
    gender bit varying(1),
    birth_date date,
    email character varying(100),
    phone character varying(20),
    address character varying(200),
    ethnic character varying(10),
    religion character varying(10),
    citizen_id character varying(10),
    tax_code character varying(10),
    social_insurance_no character varying(10),
    photo character varying,
    date_hired date,
    contract_no character varying(10),
    auth_group_id character varying(20)
);


ALTER TABLE public.user_tb OWNER TO postgres;

--
-- TOC entry 2868 (class 0 OID 27975)
-- Dependencies: 201
-- Data for Name: auth_group_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.auth_group_tb (auth_group_id, auth_group_name) VALUES ('Admin', 'Administrator');
INSERT INTO public.auth_group_tb (auth_group_id, auth_group_name) VALUES ('User', 'User');


--
-- TOC entry 2864 (class 0 OID 27947)
-- Dependencies: 197
-- Data for Name: department_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.department_tb (department_id, department_name) VALUES ('DEV', 'Development');
INSERT INTO public.department_tb (department_id, department_name) VALUES ('HR', 'Human Resource');
INSERT INTO public.department_tb (department_id, department_name) VALUES ('COMT', 'Comtor');


--
-- TOC entry 2866 (class 0 OID 27957)
-- Dependencies: 199
-- Data for Name: member_of_team_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.member_of_team_tb (team_id, member_id, "position") VALUES ('NET', 'ThanhDD', 'Member');


--
-- TOC entry 2869 (class 0 OID 27980)
-- Dependencies: 202
-- Data for Name: screen_auth_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.screen_auth_tb (auth_group_id, screen_id, allowed_to_open) VALUES ('Admin', 'frmLogin', '1');
INSERT INTO public.screen_auth_tb (auth_group_id, screen_id, allowed_to_open) VALUES ('Admin', 'frmMenu', '1');
INSERT INTO public.screen_auth_tb (auth_group_id, screen_id, allowed_to_open) VALUES ('Admin', 'frmPersonalInfo', '1');
INSERT INTO public.screen_auth_tb (auth_group_id, screen_id, allowed_to_open) VALUES ('Admin', 'frmEmployeeList', '1');
INSERT INTO public.screen_auth_tb (auth_group_id, screen_id, allowed_to_open) VALUES ('Admin', 'frmPersonalTimesheets', '1');
INSERT INTO public.screen_auth_tb (auth_group_id, screen_id, allowed_to_open) VALUES ('Admin', 'frmTimesheets', '1');


--
-- TOC entry 2867 (class 0 OID 27970)
-- Dependencies: 200
-- Data for Name: screen_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.screen_tb (screen_id, screen_name) VALUES ('frmLogin', 'Màn hình đăng nhập');
INSERT INTO public.screen_tb (screen_id, screen_name) VALUES ('frmMenu', 'Màn hình Menu');
INSERT INTO public.screen_tb (screen_id, screen_name) VALUES ('frmEmpoloyeeList', 'Màn hình danh sách nhân viên');


--
-- TOC entry 2865 (class 0 OID 27952)
-- Dependencies: 198
-- Data for Name: team_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.team_tb (team_id, department_id, team_name) VALUES ('JAVA', 'DEV', 'Java Development');
INSERT INTO public.team_tb (team_id, department_id, team_name) VALUES ('NET', 'DEV', 'NET Development');


--
-- TOC entry 2871 (class 0 OID 28047)
-- Dependencies: 204
-- Data for Name: timesheets_details_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2872 (class 0 OID 28056)
-- Dependencies: 205
-- Data for Name: timesheets_raw_data_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-30 15:37:26');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('47363565944846', '2022-11-30 15:24:38');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-30 14:58:46');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-30 14:46:19');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-30 14:40:42');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-30 14:04:41');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-30 13:38:22');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-30 13:37:07');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-30 13:33:54');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-30 13:27:27');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-30 13:19:02');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-30 13:01:27');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Dũng ', '2022-11-30 12:23:21');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Long ', '2022-11-30 12:23:00');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-30 12:22:12');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-30 12:20:58');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-30 12:20:36');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-30 12:20:24');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-30 12:18:56');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-30 11:47:11');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-30 11:47:08');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-30 11:47:05');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-30 11:34:46');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-30 11:23:23');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-30 10:40:13');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-30 10:28:50');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-30 10:25:12');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-30 09:32:13');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-30 08:26:23');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Hoàng-intern ', '2022-11-30 08:06:10');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-30 08:02:11');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-30 07:53:49');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-30 07:49:58');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Nguyễn Văn Hải ', '2022-11-30 07:44:25');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-29 17:16:28');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-29 17:04:33');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Nguyễn Đình Luân', '2022-11-29 16:42:00');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-29 16:03:59');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-29 15:46:23');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Hoàng-intern ', '2022-11-29 15:42:12');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-29 15:40:23');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-29 15:40:20');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Long ', '2022-11-29 15:17:22');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-29 15:09:33');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-29 14:46:20');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Dũng ', '2022-11-29 14:39:08');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-29 14:32:48');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-29 14:32:37');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-29 14:27:16');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-29 14:12:50');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Nguyễn Đình Luân', '2022-11-29 13:30:24');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Nguyễn Văn Hải ', '2022-11-29 13:07:31');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-29 13:06:57');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-29 13:04:55');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-29 12:55:19');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Hoàng-intern ', '2022-11-29 12:52:27');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-29 12:30:21');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-29 12:11:34');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-29 12:02:32');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-29 11:42:17');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-29 11:41:09');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-29 10:30:30');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-29 10:16:58');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-29 10:03:17');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Long ', '2022-11-29 10:00:11');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-29 09:48:54');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Nguyễn Văn Hải ', '2022-11-29 09:26:09');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-29 09:04:35');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-29 08:36:49');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-29 08:04:35');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-29 07:58:55');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Long ', '2022-11-29 07:56:11');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Nguyễn Văn Hải ', '2022-11-29 07:54:42');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-29 07:52:56');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Dũng ', '2022-11-29 07:50:34');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Văn Hoàn', '2022-11-29 07:09:43');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-28 20:44:58');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-28 16:57:47');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Dũng ', '2022-11-28 16:48:22');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-28 16:02:29');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Nguyễn Văn Hải ', '2022-11-28 14:56:11');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-28 14:19:34');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-28 14:11:00');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-28 14:09:11');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-28 13:40:13');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-28 13:34:25');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Long ', '2022-11-28 13:30:05');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-28 13:24:45');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Văn Hoàn', '2022-11-28 13:10:28');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Hoàng-intern ', '2022-11-28 13:00:38');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-28 12:37:53');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-28 12:37:08');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-28 12:36:34');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-28 12:31:21');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Long ', '2022-11-28 12:29:13');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-28 12:27:47');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-28 12:27:45');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Văn Hoàn', '2022-11-28 12:26:46');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-28 12:25:29');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-28 12:25:04');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-28 12:25:03');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Hoàng-intern ', '2022-11-28 12:24:20');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-28 11:46:40');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-28 11:31:26');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-28 08:03:09');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-28 08:03:06');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Hoàng-intern ', '2022-11-28 08:02:57');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Long ', '2022-11-28 07:59:31');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Long ', '2022-11-28 07:59:20');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Văn Hoàn', '2022-11-28 07:54:02');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('CẢNH BÁO!', '2022-11-28 07:52:57');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-28 07:52:40');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Nguyễn Văn Hải ', '2022-11-28 07:48:51');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Văn Dũng ', '2022-11-28 07:45:22');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-27 17:41:45');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-27 17:11:37');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-27 14:01:35');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-26 17:46:46');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-26 17:46:29');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-26 14:23:04');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-26 09:11:05');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Huỳnh Quốc Trung ', '2022-11-25 17:35:47');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Huỳnh Quốc Trung ', '2022-11-25 17:35:15');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-25 17:03:14');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Phan Đình Hiệp ', '2022-11-25 17:02:38');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Thị Sang ', '2022-11-25 17:00:11');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Hoàng Hảo', '2022-11-25 16:55:51');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Hữu Hùng ', '2022-11-25 16:55:18');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Nguyễn Văn Hải ', '2022-11-25 16:55:15');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('CẢNH BÁO!', '2022-11-25 16:53:04');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-25 15:28:19');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-25 15:28:14');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-25 11:52:02');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-25 08:12:20');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-24 13:24:48');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-24 09:37:39');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-23 13:09:26');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-23 13:09:14');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-21 16:26:03');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Ngô Thành Trung ', '2022-11-21 16:25:49');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-21 10:51:01');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-21 10:50:51');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-21 10:50:42');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-21 10:50:39');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-21 10:50:35');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-21 10:50:29');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-21 08:52:18');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-21 08:26:47');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Lê Sỹ Thao', '2022-11-21 07:58:20');
INSERT INTO public.timesheets_raw_data_tb (fullname, in_out_time) VALUES ('Trần Thị Hiền Vy ', '2022-11-20 08:08:58');


--
-- TOC entry 2870 (class 0 OID 28015)
-- Dependencies: 203
-- Data for Name: timesheets_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.timesheets_tb (username, fullname, year, month, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22, d23, d24, d25, d26, d27, d28, d29, d30, d31, total_working_days, total_working_hours) VALUES ('ThanhDD', 'Đường Đức Thanh', 2022, 12, 4.9, 10.1, 7.0, 1.0, 2.0, 0.0, 10.2, 1.5, 1.9, NULL, NULL, 5.2, NULL, 2.7, 2.7, NULL, NULL, NULL, NULL, 9.3, 0.0, NULL, NULL, NULL, NULL, 6.8, 9.3, 3.8, 9.3, 0.0, NULL, 16.0, 87.7);
INSERT INTO public.timesheets_tb (username, fullname, year, month, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22, d23, d24, d25, d26, d27, d28, d29, d30, d31, total_working_days, total_working_hours) VALUES ('Thanhdd', 'Đường Đức Thanh', 2022, 11, 9.1, 6.8, 0.0, NULL, 2.8, 3.6, 0.0, 2.4, 1.8, NULL, NULL, 0.0, 3.0, 8.0, 0.0, NULL, NULL, NULL, NULL, 6.8, 0.0, 0.0, 0.0, 0.0, NULL, NULL, NULL, 3.8, NULL, NULL, NULL, 10.0, 48.1);


--
-- TOC entry 2863 (class 0 OID 24081)
-- Dependencies: 196
-- Data for Name: user_tb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.user_tb (username, password, fullname, gender, birth_date, email, phone, address, ethnic, religion, citizen_id, tax_code, social_insurance_no, photo, date_hired, contract_no, auth_group_id) VALUES ('AnhNV', 'c30f02adc000b565f761a2b292b37169', 'Nguyễn Văn Anh', B'1', '1997-04-25', 'anv@gmail.com', '0379114752', 'Cẩm Lệ, Đà Nẵng', 'Kinh', 'Không', '1482663584', NULL, NULL, NULL, NULL, NULL, 'User');
INSERT INTO public.user_tb (username, password, fullname, gender, birth_date, email, phone, address, ethnic, religion, citizen_id, tax_code, social_insurance_no, photo, date_hired, contract_no, auth_group_id) VALUES ('ThanhDD', 'c30f02adc000b565f761a2b292b37169', 'Đường Đức Thanh', B'1', '1997-04-29', 'thanhdd@golineglobal.vn', '0379113210', 'Ngũ Hành Sơn, Đà Nẵng', 'Kinh', 'Không', '184272075', NULL, NULL, NULL, '2023-03-01', NULL, 'Admin');


--
-- TOC entry 2735 (class 2606 OID 28029)
-- Name: screen_auth_tb auth_screen_tb_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.screen_auth_tb
    ADD CONSTRAINT auth_screen_tb_pkey PRIMARY KEY (screen_id, auth_group_id);


--
-- TOC entry 2733 (class 2606 OID 27979)
-- Name: auth_group_tb authentication_group_tb_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.auth_group_tb
    ADD CONSTRAINT authentication_group_tb_pkey PRIMARY KEY (auth_group_id);


--
-- TOC entry 2725 (class 2606 OID 27951)
-- Name: department_tb department_tb_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.department_tb
    ADD CONSTRAINT department_tb_pkey PRIMARY KEY (department_id);


--
-- TOC entry 2729 (class 2606 OID 27961)
-- Name: member_of_team_tb member_of_team_tb_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.member_of_team_tb
    ADD CONSTRAINT member_of_team_tb_pkey PRIMARY KEY (team_id, member_id);


--
-- TOC entry 2731 (class 2606 OID 28031)
-- Name: screen_tb screen_tb_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.screen_tb
    ADD CONSTRAINT screen_tb_pkey PRIMARY KEY (screen_id);


--
-- TOC entry 2727 (class 2606 OID 27956)
-- Name: team_tb team_id_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.team_tb
    ADD CONSTRAINT team_id_pkey PRIMARY KEY (team_id);


--
-- TOC entry 2739 (class 2606 OID 28054)
-- Name: timesheets_details_tb timesheets_details_tb_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.timesheets_details_tb
    ADD CONSTRAINT timesheets_details_tb_pkey PRIMARY KEY (username, date);


--
-- TOC entry 2737 (class 2606 OID 28046)
-- Name: timesheets_tb timesheets_tb_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.timesheets_tb
    ADD CONSTRAINT timesheets_tb_pkey PRIMARY KEY (username, year, month);


--
-- TOC entry 2723 (class 2606 OID 24088)
-- Name: user_tb user_tb_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_tb
    ADD CONSTRAINT user_tb_pkey PRIMARY KEY (username);


--
-- TOC entry 2741 (class 2620 OID 28060)
-- Name: timesheets_details_tb update_time_when_duplicate_username_and_date; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_time_when_duplicate_username_and_date BEFORE INSERT ON public.timesheets_details_tb FOR EACH ROW EXECUTE PROCEDURE public.update_time_when_duplicate_username_and_date();


--
-- TOC entry 2740 (class 2620 OID 28027)
-- Name: timesheets_tb update_total_working_hours_and_days_trigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_total_working_hours_and_days_trigger BEFORE INSERT OR UPDATE ON public.timesheets_tb FOR EACH ROW EXECUTE PROCEDURE public.update_total_working_hours_and_days();


-- Completed on 2023-04-16 22:10:11

--
-- PostgreSQL database dump complete
--

