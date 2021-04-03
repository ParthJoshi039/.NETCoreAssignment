import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CompanyRoutingModule } from './company-routing.module';
import { AddCompanyComponent } from './add-company/add-company.component';
import { EditCompanyComponent } from './edit-company/edit-company.component';
import { ViewCompanyComponent } from './view-company/view-company.component';
import { ListCompanyComponent } from './list-company/list-company.component';
import { NgBootstrapFormValidationModule } from 'ng-bootstrap-form-validation';
import { MatSliderModule } from '@angular/material/slider';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';

@NgModule({
  declarations: [ AddCompanyComponent, EditCompanyComponent,  ViewCompanyComponent, ListCompanyComponent],
  imports: [
    MatSliderModule,
    MatInputModule,
    MatButtonModule,
    CommonModule,
    CompanyRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgBootstrapFormValidationModule.forRoot(),
    NgBootstrapFormValidationModule
  ]
})
export class CompanyModule { }
