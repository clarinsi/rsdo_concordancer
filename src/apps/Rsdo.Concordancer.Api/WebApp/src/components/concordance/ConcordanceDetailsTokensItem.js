import ConcordanceToken from './ConcordanceToken';

import styles from './ConcordanceDetailsTokensItem.module.scss';

const ConcordanceDetailsTokensItem = (props) => {
    const token = props.token;
    return (
        <div className={`row ${styles.item}`}>
            <div className='col-lg-4'><ConcordanceToken content={token.form} isCenterMatch={token.isCenterMatch} isWordInContextMatch={token.isWordInContextMatch} /></div>
            <div className='col-lg-4 text-secondary'><ConcordanceToken content={token.lemma} isCenterMatch={token.isCenterMatch} isWordInContextMatch={token.isWordInContextMatch} /></div>
            <div className='col-lg-4 text-secondary'><ConcordanceToken content={token.msdDescription} isCenterMatch={token.isCenterMatch} isWordInContextMatch={token.isWordInContextMatch} /></div>
        </div>
    );
};

export default ConcordanceDetailsTokensItem;