﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        /*
          private static List<Product> Products = new List<Product>
        {
        new Product
        {
            Id=1,
            Title="The Hitchhiker's Guide to the Galaxy",
            Description="The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
            ImageUrl="https://picsum.photos/200/300",
            Price=9.99m
        },
         new Product
        {
            Id=2,
            Title="Ready Player One ",
            Description="Ready Player One is a 2018 American science fiction action film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg from a screenplay by Zak Penn and Cline, it stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance. The film is set in 2045, where much of humanity uses the OASIS, a virtual reality simulation, to escape the real world. A teenage orphan finds clues to a contest that promises the ownership of the OASIS to the winner, and he and his allies try to complete it before an evil corporation can do so.",
            ImageUrl="https://picsum.photos/200/300",
            Price=7.99m
        },
         new Product
        {
            Id=3,
            Title="Nineteen Eighty-Four",
            Description="Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by the English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the authoritarian state in the novel on Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.",
            ImageUrl="https://picsum.photos/200/300",
            Price=6.99m
        }
    };
        */

        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
             _context= context;
        }

        

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var Products = await _context.Products.ToListAsync();
            return Ok(Products);
        }
    }
}
