import { Component, OnInit } from '@angular/core';
import { CompanyserviceService } from '../companyservice.service';
import { Company } from '../companyservice.model';
import { ActivatedRoute, Router, Route } from '@angular/router';
import { FormGroup, FormBuilder, FormControl, Validators, NgForm } from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import { Companies } from '../companies';


@Component({
  selector: 'app-add-company',
  templateUrl: './add-company.component.html',
  styleUrls: ['./add-company.component.css']
})
export class AddCompanyComponent implements OnInit {
  company!: Companies;
  companyForm!: FormGroup;
  matcher = new ErrorStateMatcher();
  constructor(private CompanyService:CompanyserviceService, public fb: FormBuilder,private router: Router) { }
  CompanyName = new FormControl('',[
    Validators.required,
  ]);
  // companyForm: FormGroup = new FormGroup({
  //   name : this.CompanyName
  // });
    ngOnInit(): void {
      this.companyForm = this.fb.group({
        name: [''],
        email: [''],
        totalEmployee: [''],
        address:[''],
        isCompanyActive:[''],
        totalBranch:[''],
        branchId:1,
        branchName: [''],
        branchaddress: ['']
      })
  }
    submitForm() {
      this.CompanyService.create(this.companyForm.value).subscribe(res => {
        console.log('Company created!')
        this.router.navigateByUrl('/ListCompany')
        })
    }
    
  }
