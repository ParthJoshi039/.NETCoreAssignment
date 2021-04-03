import { CompanyserviceService } from './../companyservice.service';
import { Component, OnInit } from '@angular/core';
import { Company } from '../companyservice.model';
import { Companies } from '../companies';
import { Router } from '@angular/router';

@Component({
  selector: 'app-list-company',
  templateUrl: './list-company.component.html',
  styleUrls: ['./list-company.component.css']
})
export class ListCompanyComponent implements OnInit {

  
  companies: Companies[] = [];
  id:any;  

  constructor(public CompanyService:CompanyserviceService, private router:Router) { }

  ngOnInit(): void {
   this.call()
  }

    Delete(Id:number)
    {
      this.CompanyService.delete(Id).subscribe(res=>{
        console.log(Id,'Company Deleted');
        this.call()
      })
      
    }
    call()
    {
      this.CompanyService.getAll().subscribe((data: Companies[])=>{
        console.log(data);
        this.companies=data;
      })  
    }
}
