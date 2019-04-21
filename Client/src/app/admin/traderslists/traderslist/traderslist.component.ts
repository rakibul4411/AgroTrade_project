import { Component, OnInit } from '@angular/core';
import { TraderslistService } from 'src/app/shared/traderslist.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-traderslist',
  templateUrl: './traderslist.component.html',
  styleUrls: ['./traderslist.component.css']
})
export class TraderslistComponent implements OnInit {

  
  constructor(private service: TraderslistService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Trader_ID: null,
      Trader_Name: '',
      Trader_Address: ''
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Trader_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postTradersList(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'TL. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putTradersList(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'TL. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}

