import { Component, OnInit } from '@angular/core';
import { Company } from '../companyservice.model';
import { CompanyserviceService } from '../companyservice.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Validators, FormControl, FormGroup, FormBuilder } from '@angular/forms';
import { Companies } from '../companies';

@Component({
  selector: 'app-edit-company',
  templateUrl: './edit-company.component.html',
  styleUrls: ['./edit-company.component.css']
})
export class EditCompanyComponent implements OnInit {
  id!:any;
  companies!: Companies;
  company:any;
  companyForm!: FormGroup;

  constructor(private CompanyService:CompanyserviceService, public fb: FormBuilder, private router:Router,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id');
    this.CompanyService.getById(this.id).subscribe((data)=>{
      this.companies = data;
      console.log("++",this.companies)
    })
    this.companyForm = this.fb.group({
      name:this.companies.name,
      email: this.companies.email,
      totalEmployee: this.companies.totalEmployee,
      address: this.companies.address,
      isCompanyActive: this.companies.isCompanyActive,
      totalBranch:this.companies.totalBranch,
      branchId:this.companies.branchId,
      branchName:this.companies.branchName,
      branchaddress:this.companies.branchaddress
    })
  }

  OnSubmit(){
    console.log("++",this.companies)
    this.CompanyService.update(this.id,this.companies).subscribe(res=>{
      console.log('Company Updated!')
      this.router.navigateByUrl('/ListCompany')
    })
  }

}
