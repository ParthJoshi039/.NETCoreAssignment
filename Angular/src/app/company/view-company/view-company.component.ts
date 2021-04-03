import { Component, OnInit } from '@angular/core';
import { CompanyserviceService } from '../companyservice.service';
import { Company } from '../companyservice.model';
import { Companies } from '../companies';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-view-company',
  templateUrl: './view-company.component.html',
  styleUrls: ['./view-company.component.css']
})
export class ViewCompanyComponent implements OnInit {
  id:any;
  //company:Company=new Company();
  companies!: Companies;
  

  constructor(private CompanyService:CompanyserviceService, private router:Router, private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id');
    this.CompanyService.getById(this.id).subscribe((data)=>{
      this.companies=data;
      console.log("++",data)
      });
  }

}
