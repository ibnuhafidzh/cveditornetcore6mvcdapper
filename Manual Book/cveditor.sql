PGDMP                      |            cveditor    16.3    16.3     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16654    cveditor    DATABASE     �   CREATE DATABASE cveditor WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE cveditor;
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                pg_database_owner    false            �           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   pg_database_owner    false    4            �            1259    16655    data    TABLE       CREATE TABLE public.data (
    id character varying(255),
    name character varying(255),
    gender character varying(255),
    nationality character varying(255),
    education character varying(5000),
    skills character varying(5000),
    experience character varying(999999)
);
    DROP TABLE public.data;
       public         heap    postgres    false    4            �          0    16655    data 
   TABLE DATA           \   COPY public.data (id, name, gender, nationality, education, skills, experience) FROM stdin;
    public          postgres    false    215   R       �   |   x�ȱ�  ���~����;����(w�H���^�����f��w�M��3a�l�ن��(n�9}_ꎅ�"�
�Eq=�R߰�*���ZI��5��R`m���B*u�C��N���?��(l     