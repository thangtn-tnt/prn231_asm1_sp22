﻿using AutoMapper;
using BusinessObject;
using DataAccess.Dto;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IMemberRepository
    {
        bool IsUniqueMember(string email);
        void SaveMember(Member member);
        void DeleteMember(Member member);
        void UpdateMember(Member member);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequest);
        Task<MemberDTO> Register(RegisterationRequestDTO registerationRequest);
        Member GetMemberById(int id);
        List<Member> GetMembers();
    }
}
