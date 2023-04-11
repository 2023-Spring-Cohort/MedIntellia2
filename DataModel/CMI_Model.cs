using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class CMI_Model
    {
        public List<HospitalData> hospitalDatas { get; set; }
    }

    public class HospitalData
    {
        public override string ToString()
        {
            return $"{hospital_data_id}, {data_name}";
        }
        public string hospital_data_id { get; set; }
        public string fiscal_yr { get; set; }
        public string data_ein { get; set; }
        public string data_name { get; set; }
        public string form_990_filed_part_grp_ret_f { get; set; }
        public string form_990_num_fac_oper { get; set; }
        public string form_990_name { get; set; }
        public string form_990_address { get; set; }
        public string form_990_city { get; set; }
        public string form_990_state { get; set; }
        public string form_990_zip { get; set; }
        public string tot_func_exp { get; set; }
        public string tot_revenue { get; set; }
        public string tot_comm_bnfts { get; set; }
        public string chrty_care { get; set; }
        public string unreim_medcd { get; set; }
        public string unreim_costs { get; set; }
        public string comm_hlth_impr_svcs_comm_bnft_oper { get; set; }
        public string hlth_prof_educ { get; set; }
        public string subsd_hlth_svcs { get; set; }
        public string rsrch { get; set; }
        public string cash_inknd_contrib_comm_grps { get; set; }
        public string comm_bldg { get; set; }
        public string comm_bldg_actvs { get; set; }
        public string comm_bldg_actvs_physimprvhse { get; set; }
        public string comm_bldg_actvs_econdevlp { get; set; }
        public string comm_bldg_actvs_cmntysuprt { get; set; }
        public string comm_bldg_actvs_envrnimprv { get; set; }
        public string comm_bldg_actvs_ldrdevlp { get; set; }
        public string comm_bldg_actvs_cltnbldg { get; set; }
        public string comm_bldg_actvs_htlhimprvadvcy { get; set; }
        public string comm_bldg_actvs_wrkfrcdevlp { get; set; }
        public string comm_bldg_actvs_other { get; set; }
        public object comm_bldg_actvs_physimprvhse_pct { get; set; }
        public object comm_bldg_actvs_econdevlp_pct { get; set; }
        public object comm_bldg_actvs_cmntysuprt_pct { get; set; }
        public object comm_bldg_actvs_envrnimprv_pct { get; set; }
        public object comm_bldg_actvs_ldrdevlp_pct { get; set; }
        public object comm_bldg_actvs_cltnbldg_pct { get; set; }
        public object comm_bldg_actvs_htlhimprvadvcy_pct { get; set; }
        public object comm_bldg_actvs_wrkfrcdevlp_pct { get; set; }
        public object comm_bldg_actvs_other_pct { get; set; }
        public string bad_debt { get; set; }
        public string bad_debt_tot_func_exp_atrb_pat_elig_fncl_asst { get; set; }
        public string mdcre_shrtfl { get; set; }
        public string tot_comm_bnfts_tot_func_exp_pct { get; set; }
        public string chrty_care_tot_func_exp_pct { get; set; }
        public string unreim_medcd_tot_func_exp_pct { get; set; }
        public string unreim_costs_tot_func_exp_pct { get; set; }
        public string comm_hlth_impr_svcs_comm_bnft_oper_tot_func_exp_pct { get; set; }
        public string hlth_prof_educ_tot_func_exp_pct { get; set; }
        public string subsd_hlth_svcs_tot_func_exp_pct { get; set; }
        public string rsrch_tot_func_exp_pct { get; set; }
        public string cash_inknd_contrib_comm_grps_tot_func_exp_pct { get; set; }
        public string hosp_rpt_comm_bldg_actvs_f { get; set; }
        public string comm_bldg_tot_func_exp_pct { get; set; }
        public string comm_bldg_actvs_tot_func_exp_pct { get; set; }
        public string bad_debt_tot_func_exp_pct { get; set; }
        public string bad_debt_tot_func_exp_atrb_pat_elig_fncl_asst_pct { get; set; }
        public string mdcre_shrtfl_tot_func_exp_pct { get; set; }
        public string rat_pat_care_npat_care_comm_bnfts { get; set; }
        public string sole_comm_prov_f { get; set; }
        public string written_fncl_asst_policy_f { get; set; }
        public string used_fed_pov_gdlns_det_elig_free_disc_care_f { get; set; }
        public string rpted_credit_agency_f { get; set; }
        public string filed_lawsuit_f { get; set; }
        public string placed_liens_resdnc_f { get; set; }
        public string issued_body_attch_f { get; set; }
        public string chna_cond_comm_hlth_needs_assmt_f { get; set; }
        public string chna_defined_comm_served_f { get; set; }
        public string chna_took_into_acct_input_ppl_rep_broad_intrst_comm_served_f { get; set; }
        public string chna_cond_w_mult_hosp_facilities_f { get; set; }
        public string chna_made_wide_avail_pub_f { get; set; }
        public string hosp_adp_imp_stg_addr_hlth_needs_comm_f { get; set; }
        public string hosp_exe_imp_stg_addr_hlth_needs_comm_f { get; set; }
        public string hosp_prtcp_dev_commwide_comm_bnft_plan_f { get; set; }
        public string per_capita_inc_qrt { get; set; }
        public string per_capita_inc { get; set; }
        public string med_hsehld_inc_qrt { get; set; }
        public string med_hsehld_inc { get; set; }
        public string percent_ppl_pov_qrt { get; set; }
        public string percent_ppl_pov_pct { get; set; }
        public string percent_ppl_65_yrs_old_without_hlth_insr_qrt { get; set; }
        public string percent_ppl_65_yrs_old_without_hlth_insr_pct { get; set; }
        public string unemp_rate_16_yrs_older_qrt { get; set; }
        public string unemp_rate_16_yrs_older { get; set; }
        public string st_impl_aca_medcd_exp_cvrg_adlts_w_incs_up_138pct_fpl_f { get; set; }
        public string st_inc_elig_prnts_dep_chldrn_enrol_medcd_ltd_76pct_fpl_less_f { get; set; }
        public string st_law_req_hosp_rpt_comm_bnfts_f { get; set; }
        public string paper_return_f { get; set; }
        public string netcommbldgexpns_total { get; set; }
        public string numactpgm_physimprvhse { get; set; }
        public string numactpgm_econdevlp { get; set; }
        public string numactpgm_cmntysuprt { get; set; }
        public string numactpgm_envrnimprv { get; set; }
        public string numactpgm_ldrdevlp { get; set; }
        public string numactpgm_cltnbldg { get; set; }
        public string numactpgm_htlhimprvadvcy { get; set; }
        public string numactpgm_wrkfrcdevlp { get; set; }
        public string numactpgm_other { get; set; }
        public string numactpgm_total { get; set; }
        public string prsnssrvd_physimprvhse { get; set; }
        public string prsnssrvd_econdevlp { get; set; }
        public string prsnssrvd_cmntysuprt { get; set; }
        public string prsnssrvd_envrnimprv { get; set; }
        public string prsnssrvd_ldrdevlp { get; set; }
        public string prsnssrvd_cltnbldg { get; set; }
        public string prsnssrvd_htlhimprvadvcy { get; set; }
        public string prsnssrvd_wrkfrcdevlp { get; set; }
        public string prsnssrvd_other { get; set; }
        public string prsnssrvd_total { get; set; }
        public string ttlcommbldgexpns_physimprvhse { get; set; }
        public string ttlcommbldgexpns_econdevlp { get; set; }
        public string ttlcommbldgexpns_cmntysuprt { get; set; }
        public string ttlcommbldgexpns_envrnimprv { get; set; }
        public string ttlcommbldgexpns_ldrdevlp { get; set; }
        public string ttlcommbldgexpns_cltnbldg { get; set; }
        public string ttlcommbldgexpns_htlhimprvadvcy { get; set; }
        public string ttlcommbldgexpns_wrkfrcdevlp { get; set; }
        public string ttlcommbldgexpns_other { get; set; }
        public string ttlcommbldgexpns_total { get; set; }
        public string diroffsetrev_physimprvhse { get; set; }
        public string diroffsetrev_econdevlp { get; set; }
        public string diroffsetrev_cmntysuprt { get; set; }
        public string diroffsetrev_envrnimprv { get; set; }
        public string diroffsetrev_ldrdevlp { get; set; }
        public string diroffsetrev_cltnbldg { get; set; }
        public string diroffsetrev_htlhimprvadvcy { get; set; }
        public string diroffsetrev_wrkfrcdevlp { get; set; }
        public string diroffsetrev_other { get; set; }
        public string diroffsetrev_total { get; set; }
        public string pctttlexp_physimprvhse { get; set; }
        public string pctttlexp_econdevlp { get; set; }
        public string pctttlexp_cmntysuprt { get; set; }
        public string pctttlexp_envrnimprv { get; set; }
        public string pctttlexp_ldrdevlp { get; set; }
        public string pctttlexp_cltnbldg { get; set; }
        public string pctttlexp_htlhimprvadvcy { get; set; }
        public string pctttlexp_wrkfrcdevlp { get; set; }
        public string pctttlexp_other { get; set; }
        public string pctttlexp_total { get; set; }
        public string updated_dt { get; set; }
    }
}


