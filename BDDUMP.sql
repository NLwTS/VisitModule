PGDMP      :                |            VisitDb    17.2    17.2 '    +           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            ,           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            -           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            .           1262    16462    VisitDb    DATABASE     }   CREATE DATABASE "VisitDb" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "VisitDb";
                     postgres    false            �            1259    16469    Classes    TABLE     \   CREATE TABLE public."Classes" (
    "Id" integer NOT NULL,
    "ClassName" text NOT NULL
);
    DROP TABLE public."Classes";
       public         heap r       postgres    false            �            1259    16468    Classes_Id_seq    SEQUENCE     �   ALTER TABLE public."Classes" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Classes_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public               postgres    false    219            �            1259    16525 
   Classrooms    TABLE     M   CREATE TABLE public."Classrooms" (
    "Id" integer,
    "ClassName" text
);
     DROP TABLE public."Classrooms";
       public         heap r       postgres    false            �            1259    16557    Students    TABLE     �  CREATE TABLE public."Students" (
    id integer NOT NULL,
    scholarship integer NOT NULL,
    year integer NOT NULL,
    "group" integer NOT NULL,
    studentid character varying(50) NOT NULL,
    fofeducation character varying(50) NOT NULL,
    statusscholarship character varying(3) NOT NULL,
    entrance date NOT NULL,
    dasende date NOT NULL,
    specialsituation character varying(255) NOT NULL,
    participationadditionalprograms character varying(255) NOT NULL,
    "StudentFirstName" character varying NOT NULL,
    "StudentSecondName" character varying NOT NULL,
    CONSTRAINT students_groupnumber_check CHECK (("group" >= 0)),
    CONSTRAINT students_scholarship_check CHECK (((scholarship)::numeric >= (0)::numeric)),
    CONSTRAINT students_statusscholarship_check CHECK (((statusscholarship)::text = ANY (ARRAY[('Да'::character varying)::text, ('Нет'::character varying)::text]))),
    CONSTRAINT students_year_check CHECK (((year >= 1) AND (year <= 6)))
);
    DROP TABLE public."Students";
       public         heap r       postgres    false            �            1259    16485    Visits    TABLE       CREATE TABLE public."Visits" (
    "Id" integer NOT NULL,
    "StudentId" integer NOT NULL,
    "VisitDate" timestamp with time zone NOT NULL,
    "IsPresent" boolean,
    "ClassroomId" integer,
    "Location" text,
    "Purpose" text,
    "VisitorName" text,
    "Duration" interval
);
    DROP TABLE public."Visits";
       public         heap r       postgres    false            �            1259    16484    Visits_Id_seq    SEQUENCE     �   ALTER TABLE public."Visits" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Visits_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public               postgres    false    221            �            1259    16463    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap r       postgres    false            �            1259    16583    statusscholarship    TABLE     n   CREATE TABLE public.statusscholarship (
    option text NOT NULL,
    id integer DEFAULT random() NOT NULL
);
 %   DROP TABLE public.statusscholarship;
       public         heap r       postgres    false            �            1259    16556    students_id_seq    SEQUENCE     �   CREATE SEQUENCE public.students_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.students_id_seq;
       public               postgres    false    226            /           0    0    students_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.students_id_seq OWNED BY public."Students".id;
          public               postgres    false    225            �            1259    16491    universitymember    TABLE     &  CREATE TABLE public.universitymember (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    surname character varying(100) NOT NULL,
    lastname character varying(100),
    faculty character varying(100),
    department character varying(100),
    specialization character varying(100),
    email character varying(255) NOT NULL,
    phone character varying(20),
    academicstatus character varying(50),
    gender character varying(10),
    birthday date,
    city character varying(100),
    country character varying(100),
    prefecture character varying(100),
    createdat timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    updatedat timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT chk_email_format CHECK (((email)::text ~* '^.+@.+\\..+$'::text))
);
 $   DROP TABLE public.universitymember;
       public         heap r       postgres    false            �            1259    16490    universitymember_id_seq    SEQUENCE     �   CREATE SEQUENCE public.universitymember_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.universitymember_id_seq;
       public               postgres    false    223            0           0    0    universitymember_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.universitymember_id_seq OWNED BY public.universitymember.id;
          public               postgres    false    222            u           2604    16560    Students id    DEFAULT     l   ALTER TABLE ONLY public."Students" ALTER COLUMN id SET DEFAULT nextval('public.students_id_seq'::regclass);
 <   ALTER TABLE public."Students" ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    226    225    226            r           2604    16494    universitymember id    DEFAULT     z   ALTER TABLE ONLY public.universitymember ALTER COLUMN id SET DEFAULT nextval('public.universitymember_id_seq'::regclass);
 B   ALTER TABLE public.universitymember ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    223    222    223                       0    16469    Classes 
   TABLE DATA           6   COPY public."Classes" ("Id", "ClassName") FROM stdin;
    public               postgres    false    219   �2       %          0    16525 
   Classrooms 
   TABLE DATA           9   COPY public."Classrooms" ("Id", "ClassName") FROM stdin;
    public               postgres    false    224   �2       '          0    16557    Students 
   TABLE DATA           �   COPY public."Students" (id, scholarship, year, "group", studentid, fofeducation, statusscholarship, entrance, dasende, specialsituation, participationadditionalprograms, "StudentFirstName", "StudentSecondName") FROM stdin;
    public               postgres    false    226   �2       "          0    16485    Visits 
   TABLE DATA           �   COPY public."Visits" ("Id", "StudentId", "VisitDate", "IsPresent", "ClassroomId", "Location", "Purpose", "VisitorName", "Duration") FROM stdin;
    public               postgres    false    221   =3                 0    16463    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public               postgres    false    217   �3       (          0    16583    statusscholarship 
   TABLE DATA           7   COPY public.statusscholarship (option, id) FROM stdin;
    public               postgres    false    227   �3       $          0    16491    universitymember 
   TABLE DATA           �   COPY public.universitymember (id, name, surname, lastname, faculty, department, specialization, email, phone, academicstatus, gender, birthday, city, country, prefecture, createdat, updatedat) FROM stdin;
    public               postgres    false    223   !4       1           0    0    Classes_Id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Classes_Id_seq"', 1, false);
          public               postgres    false    218            2           0    0    Visits_Id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public."Visits_Id_seq"', 2, true);
          public               postgres    false    220            3           0    0    students_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.students_id_seq', 2, true);
          public               postgres    false    225            4           0    0    universitymember_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.universitymember_id_seq', 1, false);
          public               postgres    false    222                       2606    16475    Classes PK_Classes 
   CONSTRAINT     V   ALTER TABLE ONLY public."Classes"
    ADD CONSTRAINT "PK_Classes" PRIMARY KEY ("Id");
 @   ALTER TABLE ONLY public."Classes" DROP CONSTRAINT "PK_Classes";
       public                 postgres    false    219            �           2606    16489    Visits PK_Visits 
   CONSTRAINT     T   ALTER TABLE ONLY public."Visits"
    ADD CONSTRAINT "PK_Visits" PRIMARY KEY ("Id");
 >   ALTER TABLE ONLY public."Visits" DROP CONSTRAINT "PK_Visits";
       public                 postgres    false    221            }           2606    16467 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public                 postgres    false    217            �           2606    16594 (   statusscholarship statusscholarship_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public.statusscholarship
    ADD CONSTRAINT statusscholarship_pkey PRIMARY KEY (id);
 R   ALTER TABLE ONLY public.statusscholarship DROP CONSTRAINT statusscholarship_pkey;
       public                 postgres    false    227            �           2606    16568    Students students_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public."Students"
    ADD CONSTRAINT students_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public."Students" DROP CONSTRAINT students_pkey;
       public                 postgres    false    226            �           2606    16570    Students students_studentid_key 
   CONSTRAINT     a   ALTER TABLE ONLY public."Students"
    ADD CONSTRAINT students_studentid_key UNIQUE (studentid);
 K   ALTER TABLE ONLY public."Students" DROP CONSTRAINT students_studentid_key;
       public                 postgres    false    226            �           2606    16502 +   universitymember universitymember_email_key 
   CONSTRAINT     g   ALTER TABLE ONLY public.universitymember
    ADD CONSTRAINT universitymember_email_key UNIQUE (email);
 U   ALTER TABLE ONLY public.universitymember DROP CONSTRAINT universitymember_email_key;
       public                 postgres    false    223            �           2606    16500 &   universitymember universitymember_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public.universitymember
    ADD CONSTRAINT universitymember_pkey PRIMARY KEY (id);
 P   ALTER TABLE ONLY public.universitymember DROP CONSTRAINT universitymember_pkey;
       public                 postgres    false    223            �           1259    16503    idx_university_member_email    INDEX     Y   CREATE INDEX idx_university_member_email ON public.universitymember USING btree (email);
 /   DROP INDEX public.idx_university_member_email;
       public                 postgres    false    223                   x������ � �      %   ;   x�340�0����.�]�qa߅�@��b�����.I#��!.IC.C\�@	�=... :�A�      '   =   x�3�4�4�42R�\� !��Lt�t���� 5.l���7 1/l���b;W� 2��      "   S   x�3�4�4202�54�52R00�20 "mc�?NC#�/컰�b;���/N�����K.̸0��������+F��� b��         C   x�32021422207550����,�L�q.JM,I��3�3�2BRbhZ��N�H�M������� �Z�      (      x��0��NC�s/l���i����� s[      $      x������ � �     